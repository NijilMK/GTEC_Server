using System.Reflection;

namespace MyWeb.Tools
{
    public static class Extensions
    {
        public static T CopyTo<T>(this Object sourceObject)
        {
            Type sourceObjectType = sourceObject.GetType();
            Type targetType = typeof(T);
            var targetInstance = Activator.CreateInstance(targetType, false);

            List<PropertyInfo> identicalProperties = new List<PropertyInfo>();

            var propertiesTarget = typeof(T).GetProperties();
            var propertiesSource = sourceObject.GetType().GetProperties();

            foreach (var s_property in propertiesSource)
            {
                foreach (var t_property in propertiesTarget)
                {
                    if (s_property.Name.Equals(t_property.Name))
                    {
                        identicalProperties.Add(s_property);
                        continue;
                    }
                }
            }

            object value;

            foreach (PropertyInfo property in propertiesTarget)
            {
                var res = identicalProperties.Any(x => x.Name.Equals(property.Name));
                if (!res)
                {
                    continue;
                }
                if (sourceObjectType != null)
                {
                    value = sourceObjectType.GetProperty(property.Name)
                                            .GetValue(sourceObject, null);

                    property.SetValue(targetInstance, value, null);
                }
            }

            return (T)targetInstance;
        }
    }
}
