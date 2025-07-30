using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace FirestarW {
    namespace ProceduralSwordGenerator {
        public class FileReader {

            // MenuItem Priority order in - PSG - PSG - FR - FR - Sub - Sub
            const int priority = 010000;

            static string fileReaderSettingsSOPath = "Assets/Runtime/ScriptableObjects/Settings/FileReaderSettings.asset";
            static FileReaderSettingsSO fileReaderSettingsSO;

            static string[][] ReadFiles(string folderPath, out string[] fileTypes, string fileType = "*") {
                // Checks if folder exists
                if (Directory.Exists(folderPath)) {
                    // Gets all files in path folder
                    FileInfo[] files = new DirectoryInfo(folderPath).GetFiles("*." + fileType);

                    // Return and Out parameters
                    string[][] filesToReturn = new string[files.Length][];
                    fileTypes = new string[files.Length];

                    // Adds file lines to files to return and type to files to return types
                    for (int i = 0; i < files.Length; i++) {
                        filesToReturn[i] = File.ReadAllLines(files[i].FullName);
                        fileTypes[i] = files[i].FullName.Split('.').Last();

                    }

                    return filesToReturn;

                }

                fileTypes = null;

                return null;

            }

            static void ReadFile(ref string[] lines, string fileType) {
                if (fileType == "csv") { CSVReader.ReadCSV(ref lines); return; }
                if (fileType == "json") { JSONReader.ReadJSON(ref lines); return; }

            }

            [MenuItem(MenuItemSettings.FileReader.Settings.loadSettings, false, MenuItemSettings.FileReader.Settings.loadSettingsPriority)]
            static void LoadSettings() {
                fileReaderSettingsSO = (FileReaderSettingsSO)AssetDatabase.LoadAssetAtPath(fileReaderSettingsSOPath, typeof(FileReaderSettingsSO));

                Debug.Log(fileReaderSettingsSO is null ? "Settings failed to load" : "Settings loaded succesfully");

            }

            [MenuItem(MenuItemSettings.FileReader.Settings.readNameAndIDOnly, false, MenuItemSettings.FileReader.Settings.readNameAndIDOnlyPriority)]
            static void ToggleReadNameAndIDOnly() {
                // If settings SO is missing, load
                if (fileReaderSettingsSO is null) LoadSettings();

                fileReaderSettingsSO.readNameAndIDOnly = true;

            }

            [MenuItem(MenuItemSettings.FileReader.Settings.readAllData, false, MenuItemSettings.FileReader.Settings.readAllDataPriority)]
            static void ToggleReadAllData() {
                // If settings SO is missing, load
                if (fileReaderSettingsSO is null) LoadSettings();

                fileReaderSettingsSO.readNameAndIDOnly = false;

            }

            [MenuItem(MenuItemSettings.FileReader.readAllSwordFiles, false, MenuItemSettings.FileReader.readAllSwordFilesPriorty)]
            public static void ReadAllSwordFiles() {
                ReadSwordFiles();
                ReadAllPartFiles();

            }

            [MenuItem(MenuItemSettings.FileReader.readAllPartFiles, false, MenuItemSettings.FileReader.readAllPartFilesPriorty)]
            public static void ReadAllPartFiles() {
                ReadBladeFiles();
                ReadTangFiles();
                ReadFullerFiles();
                ReadGuardFiles();
                ReadGripFiles();
                ReadPommelFiles();

            }

            [MenuItem(MenuItemSettings.FileReader.readSwordFiles, false, MenuItemSettings.FileReader.readSwordFilesPriority)]
            public static void ReadSwordFiles() {
                // If settings SO is missing, load
                if (fileReaderSettingsSO is null) LoadSettings();

                // Reads files
                string[][] files = ReadFiles(fileReaderSettingsSO.textFilesFolderPath + fileReaderSettingsSO.swordsFolderPath, out string[] fileTypes);

                // Reads each file
                if (files is not null) {
                    for (int i = 0; i < files.Length; i++) {
                        ReadFile(ref files[i], fileTypes[i]);

                    }

                } else {
                    Debug.Log("Sword files is null");

                }

            }

            [MenuItem(MenuItemSettings.FileReader.Parts.readBladeFiles, false, MenuItemSettings.FileReader.Parts.readBladeFilesPriority)]
            public static void ReadBladeFiles() {
                // If settings SO is missing, load
                if (fileReaderSettingsSO is null) LoadSettings();

                // Reads files
                string[][] files = ReadFiles(fileReaderSettingsSO.textFilesFolderPath + fileReaderSettingsSO.bladesFolderPath, out string[] fileTypes);

                // Reads each file
                if (files is not null) {
                    for (int i = 0; i < files.Length; i++) {
                        ReadFile(ref files[i], fileTypes[i]);

                    }

                } else {
                    Debug.Log("Blade files is null");

                }

            }

            [MenuItem(MenuItemSettings.FileReader.Parts.readTangFiles, false, MenuItemSettings.FileReader.Parts.readTangFilesPriority)]
            public static void ReadTangFiles() {
                // If settings SO is missing, load
                if (fileReaderSettingsSO is null) LoadSettings();

                // Reads files
                string[][] files = ReadFiles(fileReaderSettingsSO.textFilesFolderPath + fileReaderSettingsSO.tangsFolderPath, out string[] fileTypes);

                // Reads each file
                if (files is not null) {
                    for (int i = 0; i < files.Length; i++) {
                        ReadFile(ref files[i], fileTypes[i]);

                    }

                } else {
                    Debug.Log("Tang files is null");

                }

            }

            [MenuItem(MenuItemSettings.FileReader.Parts.readFullerFiles, false, MenuItemSettings.FileReader.Parts.readFullerFilesPriority)]
            public static void ReadFullerFiles() {
                // If settings SO is missing, load
                if (fileReaderSettingsSO is null) LoadSettings();

                // Reads files
                string[][] files = ReadFiles(fileReaderSettingsSO.textFilesFolderPath + fileReaderSettingsSO.fullersFolderPath, out string[] fileTypes);

                // Reads each file
                if (files is not null) {
                    for (int i = 0; i < files.Length; i++) {
                        ReadFile(ref files[i], fileTypes[i]);

                    }

                } else {
                    Debug.Log("Fuller files is null");

                }

            }

            [MenuItem(MenuItemSettings.FileReader.Parts.readGuardFiles, false, MenuItemSettings.FileReader.Parts.readGuardFilesPriority)]
            public static void ReadGuardFiles() {
                // If settings SO is missing, load
                if (fileReaderSettingsSO is null) LoadSettings();

                // Reads files
                string[][] files = ReadFiles(fileReaderSettingsSO.textFilesFolderPath + fileReaderSettingsSO.guardsFolderPath, out string[] fileTypes);

                // Reads each file
                if (files is not null) {
                    for (int i = 0; i < files.Length; i++) {
                        ReadFile(ref files[i], fileTypes[i]);

                    }

                } else {
                    Debug.Log("Guard files is null");

                }

            }

            [MenuItem(MenuItemSettings.FileReader.Parts.readGripFiles, false, MenuItemSettings.FileReader.Parts.readGripFilesPriority)]
            public static void ReadGripFiles() {
                // If settings SO is missing, load
                if (fileReaderSettingsSO is null) LoadSettings();

                // Reads files
                string[][] files = ReadFiles(fileReaderSettingsSO.textFilesFolderPath + fileReaderSettingsSO.gripsFolderPath, out string[] fileTypes);

                // Reads each file
                if (files is not null) {
                    for (int i = 0; i < files.Length; i++) {
                        ReadFile(ref files[i], fileTypes[i]);

                    }

                } else {
                    Debug.Log("Grip files is null");

                }

            }

            [MenuItem(MenuItemSettings.FileReader.Parts.readPommelFiles, false, MenuItemSettings.FileReader.Parts.readPommelFilesPriority)]
            public static void ReadPommelFiles() {
                // If settings SO is missing, load
                if (fileReaderSettingsSO is null) LoadSettings();

                // Reads files
                string[][] files = ReadFiles(fileReaderSettingsSO.textFilesFolderPath + fileReaderSettingsSO.pommelsFolderPath, out string[] fileTypes);

                // Reads each file
                if (files is not null) {
                    for (int i = 0; i < files.Length; i++) {
                        ReadFile(ref files[i], fileTypes[i]);

                    }

                } else {
                    Debug.Log("Pommel files is null");

                }

            }

        }

    }

}
