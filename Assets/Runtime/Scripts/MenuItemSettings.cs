using System.ComponentModel.Design.Serialization;
using UnityEngine;


namespace FirestarW {
    namespace ProceduralSwordGenerator {

        public class MenuItemSettings {

            const string root = "Procedural Sword Generator";

            // Priorities - PSG - PSG - PSG - S1 - S1 - S1 - S2 - S2 - S2 - S3 - S3 - S3
            const int fileReaderPriority = 001000000;

            public class FileReader {
                const string fileReaderRoot = root + "/File Reader";

                public const string readAllSwordFiles = fileReaderRoot + "/Read All Sword Files";
                public const string readAllPartFiles = fileReaderRoot + "/Read All Part Files";
                public const string readSwordFiles = fileReaderRoot + "/Read Sword Files";

                // Priorites - S1
                public const int readAllSwordFilesPriorty = fileReaderPriority + 0;
                public const int readAllPartFilesPriorty = fileReaderPriority + 1;

                public const int readSwordFilesPriority = fileReaderPriority + 001000000;
                const int partsPriortiy = fileReaderPriority + 001000001;

                const int settingsPriortiy = fileReaderPriority + 002000000;

                public class Parts {
                    const string partsRoot = fileReaderRoot + "/Parts";

                    public const string readBladeFiles = partsRoot + "/Read Blade Files";
                    public const string readTangFiles = partsRoot + "/Read Tang Files";
                    public const string readFullerFiles = partsRoot + "/Read Fuller Files";

                    public const string readGuardFiles = partsRoot + "/Read Guard Files";
                    public const string readGripFiles = partsRoot + "/Read Grip Files";
                    public const string readPommelFiles = partsRoot + "/Read Pommel Files";

                    // Priorites - S2
                    public const int readBladeFilesPriority = partsPriortiy + 0;
                    public const int readTangFilesPriority = partsPriortiy + 1;
                    public const int readFullerFilesPriority = partsPriortiy + 2;

                    public const int readGuardFilesPriority = partsPriortiy + 001000;
                    public const int readGripFilesPriority = partsPriortiy + 001001;
                    public const int readPommelFilesPriority = +partsPriortiy + 001002;

                }

                public class Settings {
                    const string settingsRoot = fileReaderRoot + "/Settings";

                    public const string readAllData = settingsRoot + "/Read All Data";
                    public const string readNameAndIDOnly = settingsRoot + "/Read Name and ID only";

                    public const string loadSettings = settingsRoot + "/Load Settings";

                    // Priorites - S2
                    public const int readAllDataPriority = settingsPriortiy + 0;
                    public const int readNameAndIDOnlyPriority = settingsPriortiy + 1;

                    public const int loadSettingsPriority = settingsPriortiy + 001000;

                }

            }

        }

    }

}