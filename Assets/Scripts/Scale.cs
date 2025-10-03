using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField]
    private float _scaleSpeed = 0.1f;

    private bool _plusPressed;
    private bool _minusPressed;
    private bool _xScalePressed;
    private bool _yScalePressed;
    private bool _zScalePressed;

    private void Start()
    {
        
    }

    private void Update()
    {
        UpdateInput();

        if (_plusPressed)
        {
            if (_xScalePressed)
            {
                transform.localScale += new Vector3(_scaleSpeed, 0f, 0f);
            }
            if (_yScalePressed)
            {
                transform.localScale += new Vector3(0f, _scaleSpeed, 0f);
            }
            if (_zScalePressed)
            {
                transform.localScale += new Vector3(0f, 0f, _scaleSpeed);
            }
        }
        if (_minusPressed)
        {
            if (_xScalePressed)
            {
                transform.localScale -= new Vector3(_scaleSpeed, 0f, 0f);
            }
            if (_yScalePressed)
            {
                transform.localScale -= new Vector3(0f, _scaleSpeed, 0f);
            }
            if (_zScalePressed)
            {
                transform.localScale -= new Vector3(0f, 0f, _scaleSpeed);
            }
        }
    }

    private void UpdateInput()
    {
        _plusPressed = Input.GetKey(KeyCode.Equals);
        _minusPressed = Input.GetKey(KeyCode.Minus);
        _xScalePressed = Input.GetKey(KeyCode.V);
        _yScalePressed = Input.GetKey(KeyCode.B);
        _zScalePressed = Input.GetKey(KeyCode.N);
    }
}
