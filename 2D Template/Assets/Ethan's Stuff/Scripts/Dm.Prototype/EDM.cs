using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class EDM
{
    public static void SaveEnemy(EnemyData enemy)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/player.TunaMayo";
        FileStream stream = new FileStream(path, FileMode.Create);

        EnemyData Edata = new EnemyData(enemy);

        formatter.Serialize(stream, Edata);
        stream.Close();
    }

    public static EnemyData LoadEnemy()
    {
        string path = Application.persistentDataPath + "/player.TunaMayo";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            EnemyData Edata = formatter.Deserialize(stream) as EnemyData;
            stream.Close();

            return Edata;
        }
        else
        {
            Debug.LogError("Saved? HA! No. " + path);
            return null;
        }
    }
}
