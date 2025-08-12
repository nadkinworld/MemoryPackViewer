using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryPack;

namespace MemoryPackViewer
{
    public static class MemoryPackHelper
    {
        public static object Deserialize(Type modelType, byte[] data)
        {
            var helperMethod = typeof(MemoryPackHelper).GetMethod(nameof(DeserializeGeneric), System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic)!;
            var genericHelper = helperMethod.MakeGenericMethod(modelType);
            return genericHelper.Invoke(null, new object[] { data })!;
        }

        private static T DeserializeGeneric<T>(byte[] data)
        {
            return MemoryPackSerializer.Deserialize<T>(data, MemoryPackSerializerOptions.Utf8);
        }
    }
}
