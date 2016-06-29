namespace Societies.Core.Infrastructure.Utils
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;
    using System.Threading.Tasks;

    public static class Cloner
    {
        public static T DeepClone<T>(T objectToBeCloned)
        {
            using (var memoryStream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(memoryStream, objectToBeCloned);
                
                // Return the pointer of the memory stream at the begining
                memoryStream.Seek(0, SeekOrigin.Begin);

                var clonedObject = (T)formatter.Deserialize(memoryStream);
                return clonedObject;
            }
        }
    }
}