using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockit.Common.Helpers
{
    public class Documentation
    {
        public class CategoryDefinition
        {
            public string category { get; set; }
            public string description { get; set; }
            public string value { get; set; }
            public List<MethodDefinition> methods { get; set; }
        }

        public class MethodDefinition
        {
            public string method { get; set; }
            public string description { get; set; }
            public string example { get; set; }
        }

        public class RootWrapper : ICustomTypeDescriptor
        {
            private readonly List<CategoryDefinition> _categories;

            public RootWrapper(List<CategoryDefinition> categories)
            {
                _categories = categories;
            }

            public PropertyDescriptorCollection GetProperties()
            {
                var props = new List<PropertyDescriptor>();
                foreach (var category in _categories)
                {
                    props.Add(new CategoryPropertyDescriptor(category.category, category));
                }
                return new PropertyDescriptorCollection(props.ToArray());
            }

            public AttributeCollection GetAttributes() => AttributeCollection.Empty;
            public string GetClassName() => "Bogus Faker Methods";
            public string GetComponentName() => "Bogus Faker Methods";
            public TypeConverter GetConverter() => null;
            public EventDescriptor GetDefaultEvent() => null;
            public PropertyDescriptor GetDefaultProperty() => null;
            public object GetEditor(Type editorBaseType) => null;
            public EventDescriptorCollection GetEvents(Attribute[] attributes) => EventDescriptorCollection.Empty;
            public EventDescriptorCollection GetEvents() => EventDescriptorCollection.Empty;
            public object GetPropertyOwner(PropertyDescriptor pd) => this;

            public PropertyDescriptorCollection GetProperties(Attribute[] attributes) => GetProperties();
        }

        public class CategoryPropertyDescriptor : PropertyDescriptor
        {
            private readonly string _name;
            private readonly CategoryDefinition _category;

            public CategoryPropertyDescriptor(string name, CategoryDefinition category) : base(name, null)
            {
                _name = name;
                _category = category;
            }

            public override Type ComponentType => typeof(RootWrapper);
            public override bool IsReadOnly => true;
            public override Type PropertyType => typeof(MethodWrapper);
            public override bool CanResetValue(object component) => false;
            public override object GetValue(object component) => new MethodWrapper(_category);
            public override void ResetValue(object component) { }
            public override void SetValue(object component, object value) { }
            public override bool ShouldSerializeValue(object component) => false;

            public override string Category => "Tokens";
            public override string Description => _category.description;
            //public override string DisplayName => string.IsNullOrWhiteSpace(_category.value) ? _name : _category.value;
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class MethodWrapper : ICustomTypeDescriptor
        {
            private readonly CategoryDefinition _category;

            public MethodWrapper(CategoryDefinition category)
            {
                _category = category;
            }

            public PropertyDescriptorCollection GetProperties()
            {
                var props = new List<PropertyDescriptor>();
                foreach (var method in _category.methods)
                {
                    props.Add(new MethodPropertyDescriptor(method, _category.category));
                }
                return new PropertyDescriptorCollection(props.ToArray());
            }

            public AttributeCollection GetAttributes() => AttributeCollection.Empty;
            public string GetClassName() => _category.category;
            public string GetComponentName() => _category.category;
            public TypeConverter GetConverter() => null;
            public EventDescriptor GetDefaultEvent() => null;
            public PropertyDescriptor GetDefaultProperty() => null;
            public object GetEditor(Type editorBaseType) => null;
            public EventDescriptorCollection GetEvents(Attribute[] attributes) => EventDescriptorCollection.Empty;
            public EventDescriptorCollection GetEvents() => EventDescriptorCollection.Empty;
            public object GetPropertyOwner(PropertyDescriptor pd) => this;

            public PropertyDescriptorCollection GetProperties(Attribute[] attributes) => GetProperties();

            public override string ToString()
            {
                return _category.value ?? _category.category ?? "Category";
            }
        }

        public class MethodPropertyDescriptor : PropertyDescriptor
        {
            private readonly MethodDefinition _method;
            private readonly string _category;

            public MethodPropertyDescriptor(MethodDefinition method, string category)
                : base(method.method, null)
            {
                _method = method;
                _category = category;
            }

            public override Type ComponentType => typeof(MethodWrapper);
            public override bool IsReadOnly => true;
            public override Type PropertyType => typeof(string);
            public override bool CanResetValue(object component) => false;
            public override object GetValue(object component) => _method.example;
            public override void ResetValue(object component) { }
            public override void SetValue(object component, object value) { }
            public override bool ShouldSerializeValue(object component) => false;

            public override string Description => _method.description;
            public override string Category => _category;
        }
    }
}
