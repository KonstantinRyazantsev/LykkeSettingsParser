using System;

namespace Lykke.SettingsReader.Exceptions
{
    public class PropertyTypeNotAssignableFromNullException : PropertyTypeException
    {
        public PropertyTypeNotAssignableFromNullException(string propertyPath, Type targetType, Exception ex = null)
            : base(propertyPath, targetType, "is not assignable from null", ex)
        { }
    }
}