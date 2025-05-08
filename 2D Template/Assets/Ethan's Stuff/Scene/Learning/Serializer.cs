
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public static class Serializer
{
    public static void Save<T>(T value, string directory, string filepath)
    {
        if (!Directory.Exists(directory))
            Directory.CreateDirectory(directory);

        string fullPath = Path.Combine(directory, filepath);
        FileMode writeMode = File.Exists(fullPath) ? FileMode.Truncate : FileMode.Create;

        using FileStream stream = new(fullPath, writeMode);
        using StreamWriter writer = new(stream);

        string json = JsonUtility.ToJson(value);

        writer.Write(json);
        writer.Flush();

        Debug.Log($"Object was totally saved to {fullPath} as {json} ");
    }
    public static T Load<T>(string directory , string fileName, T defaultValue )
    {
        if (!Directory.Exists(directory))
            Directory.CreateDirectory(directory);

        string fullPath = Path.Combine(directory, fileName);

        if (!File.Exists(fullPath))
        {
            Debug.Log($"File could not be found at {fullPath}, returning the default as {defaultValue}");
            return defaultValue;
        }

        FileMode readMode = FileMode.Open;

        using FileStream stream = new(fullPath, readMode);
        using StreamReader reader = new(stream);
        string json = reader.ReadToEnd();
        T value = JsonUtility.FromJson<T>(json);

        Debug.Log($"Object wsa successfully loaded from {fullPath} as {value}");
        return value;
    }
    public static void Delete(string filename, string directory)
    {
        Directory.CreateDirectory(directory);

        if (File.Exists(Path.Combine(directory, filename)))
        {
           File.Delete(Path.Combine(directory, filename));
        }
        else 
        {
            Debug.Log("Nah");
        }
    }
}