using UnityEngine;

namespace FirestarW {
    public class JSONReader {
        public static void ReadJSON(ref string[] lines) {
            string json = "";

            // Turns lines into single string
            foreach (string line in lines) { json += line; }

            JSONHelper.Identifier identifier = JsonUtility.FromJson<JSONHelper.Identifier>(json);

            switch (ProceduralSwordGenerator.SwordData.SwordData.StringToPartEnum(identifier.name)) {
                case ProceduralSwordGenerator.SwordData.SwordData.PartEnum.SWORD:
                    Debug.Log("Swords!");

                    ProceduralSwordGenerator.JSONSwordData.Sword[] swords = JSONHelper.FromJSONArray<ProceduralSwordGenerator.JSONSwordData.Sword>(json, out _);

                    break;

                case ProceduralSwordGenerator.SwordData.SwordData.PartEnum.BLADE:
                    Debug.Log("Blades!");

                    ProceduralSwordGenerator.JSONSwordData.Sword.Part[] blades = JSONHelper.FromJSONArray<ProceduralSwordGenerator.JSONSwordData.Sword.Part>(json, out _);

                    break;

                case ProceduralSwordGenerator.SwordData.SwordData.PartEnum.TANG:
                    Debug.Log("Tangs!");

                    ProceduralSwordGenerator.JSONSwordData.Sword.Part[] tangs = JSONHelper.FromJSONArray<ProceduralSwordGenerator.JSONSwordData.Sword.Part>(json, out _);

                    break;

                case ProceduralSwordGenerator.SwordData.SwordData.PartEnum.FULLER:
                    Debug.Log("Fullers!");

                    ProceduralSwordGenerator.JSONSwordData.Sword.Part[] fullers = JSONHelper.FromJSONArray<ProceduralSwordGenerator.JSONSwordData.Sword.Part>(json, out _);

                    break;

                case ProceduralSwordGenerator.SwordData.SwordData.PartEnum.GUARD:
                    Debug.Log("Guards!");

                    ProceduralSwordGenerator.JSONSwordData.Sword.Part[] guards = JSONHelper.FromJSONArray<ProceduralSwordGenerator.JSONSwordData.Sword.Part>(json, out _);

                    break;

                case ProceduralSwordGenerator.SwordData.SwordData.PartEnum.GRIP:
                    Debug.Log("Grips!");

                    ProceduralSwordGenerator.JSONSwordData.Sword.Part[] grips = JSONHelper.FromJSONArray<ProceduralSwordGenerator.JSONSwordData.Sword.Part>(json, out _);

                    break;

                case ProceduralSwordGenerator.SwordData.SwordData.PartEnum.POMMEL:
                    Debug.Log("Pommels!");

                    ProceduralSwordGenerator.JSONSwordData.Sword.Part[] pommels = JSONHelper.FromJSONArray<ProceduralSwordGenerator.JSONSwordData.Sword.Part>(json, out _);

                    break;

            }

        }

    }

}
