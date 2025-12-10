using System.Collections.Generic;
using UnityEngine;

public class ChangeObjects : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _objects;

    private List<Renderer> _renderers;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _renderers = new();
        foreach (GameObject item in _objects)
        {
            _renderers.Add(item.GetComponent<Renderer>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PaintToRed()
    {
        foreach (Renderer item in _renderers)
        {
            item.material.color = Color.red;
        }
    }

    public void PaintToGreen()
    {
        foreach (Renderer item in _renderers)
        {
            item.material.color = Color.green;
        }
    }

    public void PaintToBlue()
    {
        foreach (Renderer item in _renderers)
        {
            item.material.color = Color.blue;
        }
    }
}
