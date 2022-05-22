using System;
using System.Linq;
using System.Runtime.Serialization;

namespace _4kyu
{
    internal class ReflectionCompleteInvoke
    {
        public string InvokeMethod(string typeName)
        {
            try
            {
                var type = Type.GetType(typeName);

                if (string.IsNullOrEmpty(typeName))
                    return typeName;

                return (string)type?.GetMethods()
                .Where(d => d.ReturnType == typeof(string) && d.GetParameters().Length == 0).First()?
                    .Invoke(FormatterServices.GetUninitializedObject(type), null);
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }
    }
}
