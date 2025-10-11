using Mockit.Common.Constants;
using Mockit.Controls;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;
using static ScintillaNET.Style;

namespace Mockit
{
    [
        Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Bulk Data Creator"),
        ExportMetadata("Description", "This tool can create bulk records within CRM."),
        ExportMetadata("SmallImageBase64", Common.Constants.Icons.BigIcon),
        ExportMetadata("BigImageBase64", Common.Constants.Icons.BigIcon ),
        ExportMetadata("BackgroundColor", "Lavender"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")
    ]
    public class BasePlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new BaseControl();
        }

        public BasePlugin(){}

        //private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        //{
        //    Assembly loadAssembly = null;
        //    Assembly currAssembly = Assembly.GetExecutingAssembly();

        //    var argName = args.Name.Substring(0, args.Name.IndexOf(","));

        //    List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
        //    var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

        //    if (refAssembly != null)
        //    {
        //        string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
        //        string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
        //        dir = Path.Combine(dir, folder);

        //        var assmbPath = Path.Combine(dir, $"{argName}.dll");

        //        if (File.Exists(assmbPath))
        //        {
        //            loadAssembly = Assembly.LoadFrom(assmbPath);
        //        }
        //        else
        //        {
        //            throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
        //        }
        //    }

        //    return loadAssembly;
        //}
    }
}