using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float _speed = 0.1f;

    private bool _xPositivePressed;
    private bool _xNegativePressed;
    private bool _zPositivePressed;
    private bool _zNegativePressed;
    private bool _yPositivePressed;
    private bool _yNegativePressed;

    private void Start()
    {

    }

    private void Update()
    {
        UpdateInput();
        if (_xPositivePressed)
        {
            transform.position += new Vector3(_speed, 0f, 0f);
        }
        if (_xNegativePressed)
        {
            transform.position -= new Vector3(_speed, 0f, 0f);
        }
        if (_yPositivePressed)
        {
            transform.position += new Vector3(0f, _speed, 0f);
        }
        if (_yNegativePressed)
        {
            transform.position -= new Vector3(0f, _speed, 0f);
        }
        if (_zPositivePressed)
        {
            transform.position += new Vector3(0f, 0f, _speed);
        }
        if (_zNegativePressed)
        {
            transform.position -= new Vector3(0f, 0f, _speed);
        }
    }

    private void UpdateInput()
    {
        _xPositivePressed = Input.GetKey(KeyCode.D);
        _xNegativePressed = Input.GetKey(KeyCode.A);
        _yPositivePressed = Input.GetKey(KeyCode.Q);
        _yNegativePressed = Input.GetKey(KeyCode.E);
        _zPositivePressed = Input.GetKey(KeyCode.W);
        _zNegativePressed = Input.GetKey(KeyCode.S);
    }
}
