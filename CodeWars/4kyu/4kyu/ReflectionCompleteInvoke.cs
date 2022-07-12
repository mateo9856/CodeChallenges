using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace _4kyu
{
    internal class ReflectionCompleteInvoke
    {
        public string InvokeMethod(string typeName)
        {
            try
            {
                //get type 
                var type = Type.GetType(typeName);
                //check if value is not null or empty
                if (string.IsNullOrEmpty(typeName))
                    return typeName;

                //get methods where length parameter equal 0 and return type is string
                return (string)type?.GetMethods()
                .Where(d => d.ReturnType == typeof(string) && d.GetParameters().Length == 0).First()?
                    .Invoke(FormatterServices.GetUninitializedObject(type), null);
            }
            catch (ArgumentNullException)
            {//if typeName as parameter is null and 
                return null;
            }
        }
    }
}
