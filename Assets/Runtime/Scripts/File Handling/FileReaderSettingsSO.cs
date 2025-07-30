using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "FileReaderSettings", menuName = "Scriptable Objects/FileReaderSettings")]
public class FileReaderSettingsSO : ScriptableObject {
    [Header("Main Text Files Folder")]
    public string textFilesFolderPath = "Assets/Runtime/Text Files/";

    [Header("Swords Folder")]
    public string swordsFolderPath = "Swords/";

    [Header("Parts Folders")]
    public string bladesFolderPath = "Blades/";
    public string tangsFolderPath = "Tangs/";
    public string fullersFolderPath = "Fullers/";
    public string guardsFolderPath = "Guards/";
    public string gripsFolderPath = "Grips/";
    public string pommelsFolderPath = "Pommels/";

    [Header("Settings")]
    public bool readNameAndIDOnly = false;

}
