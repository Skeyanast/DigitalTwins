using Assets.Scripts;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjects : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _objectsProxy;

    private List<ChangableObject> _objects;
    private IEnumerator<ChangableObject> _currentEnumerator;

    void Start()
    {
        _objects = new();
        foreach (GameObject item in _objectsProxy)
        {
            _objects.Add(new ChangableObject(item));
        }
        _currentEnumerator = _objects.GetEnumerator();
        MoveNext();
    }

    void Update()
    {
        
    }

    public void PaintToRed()
    {
        _currentEnumerator.Current.Renderer.material.color = Color.red;
    }

    public void PaintToGreen()
    {
        _currentEnumerator.Current.Renderer.material.color = Color.green;
    }

    public void PaintToBlue()
    {
        _currentEnumerator.Current.Renderer.material.color = Color.blue;
    }

    public void Paint(Color color)
    {
        _currentEnumerator.Current.Renderer.material.color = color;
    }

    public void MoveNext()
    {
        Iterate();
        DisplayCurrentObject();
    }

    private void Iterate()
    {
        if (!_currentEnumerator.MoveNext())
        {
            _currentEnumerator.Reset();
            _currentEnumerator.MoveNext();
        }
    }

    private void DisplayCurrentObject()
    {
        _currentEnumerator.Current.Renderer.material.color = Color.lightGray;
    }
}
