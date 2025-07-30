using System.Collections.Generic;
using UnityEngine;

namespace FirestarW {
    namespace ProceduralSwordGenerator {
        public class SwordDesigner : MonoBehaviour {

            [SerializeField] List<GameObject> swords;

            public bool swordDesignerMode = false;

            private void Update() {
                
                if (Input.GetKeyDown(KeyCode.F4)) {
                    //Debug.Log("C pressed, created sword");

                    //swords.Add(SwordCreator.CreateSword(new SwordData.SwordData(), "Swordy sword"));

                    swordDesignerMode ^= true;

                    Debug.Log(swordDesignerMode ? "Entering sword designer" : "Exiting sword designer");

                }

                if (swordDesignerMode) DesignSword();

            }

            private void DesignSword() {
                // Display ui to select what part to design

            }            

        }

    }

}