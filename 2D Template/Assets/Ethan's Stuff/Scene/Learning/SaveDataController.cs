using UnityEngine;

public class SaveDataController : MonoBehaviour
{
    public static SaveDataController Instance;

    public string fileName;

    public SaveDataAsset defaultData;

    private SaveData _currentData;
    public ref SaveData Current => ref _currentData; // Grabs the private data it being a function dressed as a variable.
    //ref stands for reference making a ref of the data changing data via reference.

    private void Awake()
    {
        Instance = this;
        Load();
    }
    private void OnDestroy()
    {
       Save();
    }
    public void Save()
    {
        Serializer.Save(_currentData, $"{Application.persistentDataPath}/SaveData", fileName);
    }
    public void Load()
    {
        _currentData = Serializer.Load($"{Application.persistentDataPath}/SaveData", fileName, defaultData.value);
    }
}