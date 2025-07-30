using System;
using UnityEngine;

namespace FirestarW {
    namespace ProceduralSwordGenerator {
        namespace SwordData {

            public class SwordData {
                public enum PartEnum { NONE, SWORD, BLADE, TANG, FULLER, GUARD, GRIP, POMMEL };

                public static PartEnum StringToPartEnum(string s) {
                    PartEnum partEnum = PartEnum.NONE;

                    if (s == "sword"  || s == "swords")  partEnum = PartEnum.SWORD;

                    if (s == "blade"  || s == "blades")  partEnum = PartEnum.BLADE;
                    if (s == "tang"   || s == "tangs")   partEnum = PartEnum.TANG;
                    if (s == "fuller" || s == "fullers") partEnum = PartEnum.FULLER;

                    if (s == "guard"  || s == "guards")  partEnum = PartEnum.GUARD;
                    if (s == "grip"   || s == "grips")   partEnum = PartEnum.GRIP;
                    if (s == "pommel" || s == "pommels") partEnum = PartEnum.POMMEL;

                    return partEnum;

                }

                [Serializable]
                public enum Facing { FRONT, BACK, LEFT, RIGHT, UP, DOWN };

                [Serializable]
                public class Sword {
                    [Header("Identifiers")]
                    public string name;
                    public int id;
                    public string type;

                    [Header("Parts")]
                    public BladeAndTang bladeAndTang;
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

                    [Header("Offset")]
                    public Vector3 offset;

                    [Serializable]
                    public struct Profiles {
                        [Header("Profiles")]
                        public Profile[] left;
                        public Profile[] right;

                        [Header("Instantiated")]
                        public bool instantiated;



                    }

                    [Serializable]
                    public struct CrossSections {
                        [Header("Cross Sections")]
                        public Profile[] leftFront;
                        public Profile[] leftBack;
                        public Profile[] rightFront;
                        public Profile[] rightBack;

                        [Header("Instantiated")]
                        public bool instantiated;


                    }

                }

                [Serializable]
                public class Blade {
                    public Part blade;
                    public Fullers fullers;

                    [Header("Dimensions")]
                    public Dimensions dimensions;

                    [Header("Weight and Point of Balance")]
                    public float weight;
                    public float pob;

                    [Serializable]
                    public struct Fullers {
                        public Fuller[] front;
                        public Fuller[] back;

                        [Header("Instantiated")]
                        public bool instantiated;

                    }

                }

                [Serializable]
                public struct BladeAndTang {
                    public Blade blade;
                    public Part tang;

                    [Header("Dimensions")]
                    public Dimensions dimensions;

                    [Header("Weight and Point of Balance")]
                    public float weight;
                    public float pob;

                    [Header("Instantiated")]
                    public bool instantiated;

                }

                [Serializable]
                public class Profile {
                    [Header("Mid Points")]
                    public float bottomMidPoint;
                    public float topMidPoint;

                    [Header("Length")]
                    public float length;

                    [Header("Widths")]
                    public float bottomWidth;
                    public float topWidth;

                }

                [Serializable]
                public class CurvedProfile : Profile {
                    public bool convex;

                }

                [Serializable]
                public class Fuller {
                    // Data

                    [Header("Offset")]
                    public Vector3 offset;

                }

                [Serializable]
                public struct Dimensions {
                    public float length;
                    public float width;
                    public float thickness;

                }

            }

        }

    }

}