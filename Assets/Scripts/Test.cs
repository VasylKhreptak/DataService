using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Awake()
    {
        HashSet<int> hashSet = new HashSet<int>();

        hashSet.Add(1);

        string data = JsonConvert.SerializeObject(hashSet);
        
        hashSet = JsonConvert.DeserializeObject<HashSet<int>>(data);

        Debug.Log(hashSet.Contains(1));
    }
}
