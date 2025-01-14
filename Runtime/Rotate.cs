using UnityEngine;

namespace EdenMeng.TestPackage
{
    public class Rotate : MonoBehaviour
    {
        private void Update()
        {
            transform.Rotate(new Vector3(0, 0, 5));
        }
    }
}