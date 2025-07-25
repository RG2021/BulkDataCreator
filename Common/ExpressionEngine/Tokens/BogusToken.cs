using Bogus;
using Microsoft.Crm.Sdk.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mockit.Common.ExpressionEngine.Tokens
{
    internal class BogusToken : BaseToken
    {
        public override string Name => "Mock";

        public override string Execute(string args)
        {
            try
            {
                // Parse path and arguments
                string path = args;
                string methodArgs = "";
                int parenIndex = args.IndexOf('(');
                if (parenIndex > 0)
                {
                    path = args.Substring(0, parenIndex).Trim();
                    methodArgs = args.Substring(parenIndex + 1, args.Length - parenIndex - 2); // remove parentheses
                }

                // Split path, e.g. RANDOM.DOUBLE
                var parts = path.Split('.');
                object current = Faker;
                Type currentType = typeof(Faker);

                foreach (var part in parts)
                {
                    var prop = currentType.GetProperty(part, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                    if (prop != null)
                    {
                        current = prop.GetValue(current);
                        currentType = prop.PropertyType;
                    }
                    else
                    {
                        var methods = currentType.GetMethods(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance)
                            .Where(m => m.Name.Equals(part, StringComparison.OrdinalIgnoreCase)).ToArray();

                        if (methods.Length > 0)
                        {
                            var argList = string.IsNullOrWhiteSpace(methodArgs) ? new string[0] : methodArgs.Split(',').Select(a => a.Trim()).Where(a => a.Length > 0).ToArray();

                            // Prefer exact match, fallback to zero-parameter overload if no args
                            MethodInfo method = methods.FirstOrDefault(m => m.GetParameters().Length == argList.Length);
                            if (method == null && argList.Length == 0)
                                method = methods[0];

                            if (method == null)
                                return $"[No overload of '{part}' matches {argList.Length} arguments]";

                            var parameters = method.GetParameters();
                            object[] convertedArgs = new object[parameters.Length];
                            for (int i = 0; i < parameters.Length && i < argList.Length; i++)
                            {
                                try
                                {
                                    var paramType = parameters[i].ParameterType;
                                    var arg = argList[i];

                                    // Handle Nullable<T>
                                    if (paramType.IsGenericType && paramType.GetGenericTypeDefinition() == typeof(Nullable<>))
                                        paramType = Nullable.GetUnderlyingType(paramType);

                                    // Handle enums (e.g., Gender)
                                    if (paramType.IsEnum)
                                        convertedArgs[i] = Enum.Parse(paramType, arg, true);
                                    else
                                        convertedArgs[i] = Convert.ChangeType(arg, paramType);
                                }
                                catch (Exception)
                                {
                                    return $"[Invalid value for parameter '{parameters[i].Name}' of type '{parameters[i].ParameterType.Name}']";
                                }
                            }
                            try
                            {
                                var result = method.Invoke(current, convertedArgs);
                                return result?.ToString() ?? "";
                            }
                            catch (TargetInvocationException ex)
                            {
                                return $"[Error invoking method: {ex.InnerException?.Message ?? ex.Message}]";
                            }
                            catch (Exception ex)
                            {
                                return $"[Error invoking method: {ex.Message}]";
                            }
                        }
                        return $"[Method {part} not found]";
                    }
                }
                return current?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                return $"[Invalid token or value: {ex.Message}]";
            }
        }
    }
}
