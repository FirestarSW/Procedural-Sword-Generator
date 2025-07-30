using Unity.VisualScripting;
using UnityEngine;

namespace FirestarW {
    namespace ProceduralSwordGenerator {
        public class Profile2D : MonoBehaviour {

            [SerializeField] LineRenderer lineRenderer;

            [Header("Positions")]
            [SerializeField] float length;
            [SerializeField] float bottomWidth;
            [SerializeField] float topWidth;

            [SerializeField] Vector3 offset;
            [SerializeField] float bottomOffset;
            [SerializeField] float topOffset;

            [SerializeField] bool mirrorYZ;

            private void Start() {
                if (!lineRenderer) gameObject.AddComponent<LineRenderer>();

                lineRenderer = GetComponent<LineRenderer>();
                lineRenderer.material = new Material(Shader.Find("Sprites/Default"));

                lineRenderer.useWorldSpace = true;

                lineRenderer.startColor = Color.red;
                lineRenderer.endColor = Color.green;

                lineRenderer.startWidth = 0.2f;
                lineRenderer.endWidth = 0.2f;

                lineRenderer.positionCount = 5;

                Vector3[] positions = { offset + new Vector3(bottomOffset, 0, 0), offset + new Vector3(topOffset, length, 0), offset + new Vector3(topWidth + topOffset, length, 0), offset + new Vector3(bottomWidth + bottomOffset, 0, 0), offset + new Vector3(bottomOffset, 0, 0) };

                if (mirrorYZ) {
                    for (int i = 0; i < positions.Length; i++) {
                        positions[i].x *= -1;

                    }

                }

                lineRenderer.SetPositions(positions);

            }

            private void Update() {
                Vector3[] positions = { offset + new Vector3(bottomOffset, 0, 0), offset + new Vector3(topOffset, length, 0), offset + new Vector3(topWidth + topOffset, length, 0), offset + new Vector3(bottomWidth + bottomOffset, 0, 0), offset + new Vector3(bottomOffset, 0, 0) };

                if (mirrorYZ) {
                    for (int i = 0; i < positions.Length; i++) {
                        positions[i].x *= -1;

                    }

                }

                lineRenderer.SetPositions(positions);

            }


        }

    }

}