using UnityEngine;

namespace FirestarW {
    namespace ProceduralSwordGenerator {

        [CreateAssetMenu(fileName = "SwordData", menuName = "Scriptable Objects/SwordData")]
        public class SwordDataSO : ScriptableObject {
            public SwordData.SwordData.Sword sword;

        }

    }

}