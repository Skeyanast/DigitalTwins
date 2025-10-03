using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float _x;
    private float _y;
    private float _z;
    private bool _xPressed;
    private bool _yPressed;
    private bool _zPressed;

    private void Start()
    {
        
    }

    private void Update()
    {
        UpdateInput();
        UpdateEulers();
        transform.rotation = Quaternion.Euler(_x, _y, _z);
    }

    private void UpdateInput()
    {
        _xPressed = Input.GetKey(KeyCode.X);
        _yPressed = Input.GetKey(KeyCode.Y);
        _zPressed = Input.GetKey(KeyCode.Z);
    }

    private void UpdateEulers()
    {
        if (_xPressed) _x++;
        if (_yPressed) _y++;
        if (_zPressed) _z++;
    }
}
