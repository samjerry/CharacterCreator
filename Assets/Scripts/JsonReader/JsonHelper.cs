using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class JsonHelper : MonoBehaviour
{
    private struct JsonArrayWrapper<T>
    {
        public T wrap_result;
    }

    public static T ParseJsonArray<T>(string json)
    {
        var temp = JsonUtility.FromJson<JsonArrayWrapper<T>>("{\"wrap_result\":" + json + "}");
        return temp.wrap_result;
    }
}
