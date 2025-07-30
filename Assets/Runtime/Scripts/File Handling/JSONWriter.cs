using FirestarW.ProceduralSwordGenerator.SwordData;
using UnityEngine;

namespace FirestarW {
    public class JSONWriter : MonoBehaviour {

        //[SerializeField] ProceduralSwordGenerator.SwordData.Sword sword;
        [SerializeField] string json;

        [SerializeField] ProceduralSwordGenerator.JSONSwordData.Sword[] data;


        void Start() {
            ProceduralSwordGenerator.JSONSwordData.Sword[] swords = new ProceduralSwordGenerator.JSONSwordData.Sword[3];

            for (int i = 0; i < swords.Length; i++) {
                swords[i] = new ProceduralSwordGenerator.JSONSwordData.Sword();

                swords[i].fullers = new ProceduralSwordGenerator.JSONSwordData.Sword.Fuller[1];
                swords[i].fullers[0] = new ProceduralSwordGenerator.JSONSwordData.Sword.Fuller();

                swords[i].guards = new ProceduralSwordGenerator.JSONSwordData.Sword.Part[1];
                swords[i].guards[0] = new ProceduralSwordGenerator.JSONSwordData.Sword.Part();

            }

            json = JSONHelper.ToJSONArray(swords, "swords");

            data = JSONHelper.FromJSONArray<ProceduralSwordGenerator.JSONSwordData.Sword>(json, out _);


        }

        [SerializeField] ProceduralSwordGenerator.JSONSwordData.Sword sword;
        

    }

}