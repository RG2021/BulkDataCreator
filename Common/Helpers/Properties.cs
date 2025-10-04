using Mockit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockit.Common.Helpers
{
    public class Properties
    {
        public class DynamicProperty
        {
            public string Name { get; }
            public object Value { get; set; }
            public string Category { get; }

            public DynamicProperty(string name, object value, string category = null)
            {
                Name = name;
                Value = value;
                Category = category;
            }
        }

        public class DynamicPropertyDescriptor : PropertyDescriptor
        {
            private readonly DynamicProperty _property;

            public DynamicPropertyDescriptor(DynamicProperty property)
                : base(property.Name, null)
            {
                _property = property;
            }

            public override bool CanResetValue(object component) => false;
            public override Type ComponentType => typeof(object);
            public override object GetValue(object component) => _property.Value;
            public override void SetValue(object component, object value) => _property.Value = value;
            public override bool IsReadOnly => true;
            public override Type PropertyType => _property.Value?.GetType() ?? typeof(object);
            public override void ResetValue(object component) { }
            public override bool ShouldSerializeValue(object component) => false;
            public override string Category => _property.Category;
            public override string Description => $"{_property.Value}";
        }

        public static class CRMFieldPropertyHelper
        {
            public static ICustomTypeDescriptor CreatePropertyDescriptor(CRMField field)
            {
                var props = new List<DynamicProperty>
                {
                    new DynamicProperty("Display Name", field.DisplayName, "General"),
                    new DynamicProperty("Logical Name", field.LogicalName, "General"),
                    new DynamicProperty("Data Type", field.DataType, "General"),
                };

                if (field.Metadata != null && field.Metadata.Any())
                {
                    foreach (var m in field.Metadata)
                    {
                        props.Add(new DynamicProperty(m.Name, m.Value, "Metadata"));
                    }
                }

                return new DynamicTypeDescriptor(props);
            }
        }

        // ICustomTypeDescriptor implementation
        public class DynamicTypeDescriptor : ICustomTypeDescriptor
        {
            private readonly List<DynamicProperty> _properties;

            public DynamicTypeDescriptor(List<DynamicProperty> properties)
            {
                _properties = properties;
            }

            public PropertyDescriptorCollection GetProperties()
            {
                var list = _properties.Select(p => new DynamicPropertyDescriptor(p)).ToArray();
                return new PropertyDescriptorCollection(list);
            }

            public PropertyDescriptorCollection GetProperties(Attribute[] attributes) => GetProperties();
            public AttributeCollection GetAttributes() => AttributeCollection.Empty;
            public string GetClassName() => null;
            public string GetComponentName() => null;
            public TypeConverter GetConverter() => null;
            public EventDescriptor GetDefaultEvent() => null;
            public PropertyDescriptor GetDefaultProperty() => null;
            public object GetEditor(Type editorBaseType) => null;
            public EventDescriptorCollection GetEvents() => EventDescriptorCollection.Empty;
            public EventDescriptorCollection GetEvents(Attribute[] attributes) => EventDescriptorCollection.Empty;
            public object GetPropertyOwner(PropertyDescriptor pd) => this;
        }
    }
}
