using UnityEngine;

namespace Assets.Scripts
{
    public class PhysicalObject : IPaintable
    {
        public GameObject GameObject { get; }
        public Renderer Renderer { get; }

        public PhysicalObject(GameObject gameObject)
        {
            GameObject = gameObject;
            Renderer = gameObject.GetComponent<Renderer>();
        }

        public void Paint(Color color)
        {
            Renderer.material.color = color;
        }
    }
}
