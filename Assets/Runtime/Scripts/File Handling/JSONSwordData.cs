using UnityEngine;
using System;
using System.CodeDom.Compiler;
using static FirestarW.ProceduralSwordGenerator.SwordData.SwordData;

namespace FirestarW {
    namespace ProceduralSwordGenerator {
        public class JSONSwordData {

            [Serializable]
            public class Sword {
                [Header("Identifiers")]
                public string name;
                public int id;
                public string type;

                [Header("Parts")]
                public Part blade;
                public Part tang;
                public Fuller[] fullers;

                public Part[] guards;
                public Part grip;
                public Part pommel;

                [Header("Dimensions")]
                public Dimensions dimensions;

                [Header("Weight and Point of Balance")]
                public float weight;
                public float pob;

                [Header("Materials")]
                public string[] materials;

                public Sword(bool initDefault = false) { if (initDefault) { fullers = new Fuller[1]; guards = new Part[1]; } }

                [Serializable]
                public class Part {
                    public int id;
                    public Vector3 offset;

                    public Flip flip;

                    [Serializable]
                    public struct Flip {
                        public bool x;
                        public bool y;
                        public bool z;

                    }

                }

                [Serializable]
                public class Fuller {
                    public int id;
                    public Vector3 offset;

                    public Rotation rotation;

                    [Serializable]
                    public struct Rotation {
                        public float x;
                        public float y;
                        public float z;

                    }

                }

            }        

        }

        [Serializable]
        public class Part {
            [Header("Identifiers")]
            public string name;
            public int id;
            public string type;

            [Header("Profiles and Cross Sections")]
            public Profiles profiles;
            public CrossSections crossSections;

            [Header("Weight and Point of Balance")]
            public float weight;
            public float pob;

            [Header("Materials")]
            public string[] materials;

            [Serializable]
            public class Profile {


            }

            [Serializable]
            public struct Profiles {
                [Header("Profiles")]
                public Profile[] left;
                public Profile[] right;

            }

            [Serializable]
            public struct CrossSections {
                [Header("Cross Sections")]
                public Profile[] leftFront;
                public Profile[] leftBack;
                public Profile[] rightFront;
                public Profile[] rightBack;

            }

        }

        [Serializable]
        public struct Dimensions {
            public float length;
            public float width;
            public float thickness;

        }

    }

}