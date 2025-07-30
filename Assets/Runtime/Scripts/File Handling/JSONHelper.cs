using UnityEngine;
using System;

namespace FirestarW {
    public class JSONHelper {

        public static T[] FromJSONArray<T>(string json, out string name) {
            ArrayWrapper<T> arrayWrapper = JsonUtility.FromJson<ArrayWrapper<T>>(json);

            name = arrayWrapper.name;

            return arrayWrapper.array;

        }

        public static string ToJSONArray<T>(T[] array, string name = "") {
            return JsonUtility.ToJson(new ArrayWrapper<T>(array, name));

        }

        [Serializable]
        public struct Identifier {
            public string name;
            public int id;

        }

        [Serializable]
        private class ArrayWrapper<T> {
            public string name;
            public T[] array;

            public ArrayWrapper() { }
            public ArrayWrapper(T[] array, string name = "") { this.array = array; this.name = name; }

        }


    }

}