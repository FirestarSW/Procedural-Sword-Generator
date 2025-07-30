using UnityEngine;

namespace FirestarW {
    namespace ProceduralSwordGenerator {
        public class SwordCreator : MonoBehaviour {

            static int swordNum;

            public static GameObject CreateSword(SwordData.SwordData swordData, string name = "") {
                Debug.Log("Sword Created");

                GameObject sword = new GameObject(name == "" ? "Sword " + swordNum: name);

                return sword;

            }

        }

    }

}