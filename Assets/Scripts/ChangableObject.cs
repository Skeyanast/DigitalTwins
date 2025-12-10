using UnityEngine;

namespace Assets.Scripts
{
    public class ChangableObject
    {
        public GameObject GameObject { get; }
        public Renderer Renderer { get; }

        public ChangableObject(GameObject gameObject)
        {
            GameObject = gameObject;
            Renderer = gameObject.GetComponent<Renderer>();
        }
    }
}
