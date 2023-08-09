using System.Reflection;

namespace Common
{
    public static class EnumExtension
    {
        public static string GetKey<T>(this T value)
        {
            Type type = typeof(T);
            FieldInfo fieldInfo = type.GetField(value.ToString());
            EnumKeyAttribute[] keyAttributes = fieldInfo.GetCustomAttributes(typeof(EnumKeyAttribute), false) as EnumKeyAttribute[];

            return keyAttributes.Length > 0 ? keyAttributes[0].Key : null;
        }
    }
}