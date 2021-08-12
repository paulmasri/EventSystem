using UnityEngine;

namespace lisandroct.EventSystem
{
    public class Detector : MonoBehaviour
    {
        public void OnEventRaised()
        {
            Debug.Log($"Raised {gameObject.name}");
        }
    }
}
