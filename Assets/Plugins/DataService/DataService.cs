using Newtonsoft.Json;
using UnityEngine;

namespace Plugins.DataService
{
    public static class DataService
    {
        public static void Save<T>(T data, string key)
        {
            string jsonData = JsonConvert.SerializeObject(data);

            PlayerPrefs.SetString(key, jsonData);
        }

        public static T Load<T>(string key)
        {
            string jsonData = PlayerPrefs.GetString(key);

            return JsonConvert.DeserializeObject<T>(jsonData);
        }

        public static T Load<T>(string key, T defaultValue)
        {
            string jsonData = PlayerPrefs.GetString(key);

            if (string.IsNullOrEmpty(jsonData))
            {
                return defaultValue;
            }

            return JsonConvert.DeserializeObject<T>(jsonData);
        }

        public static bool HasKey(string key)
        {
            return PlayerPrefs.HasKey(key);
        }
    }
}
