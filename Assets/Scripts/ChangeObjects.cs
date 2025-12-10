using UnityEngine;

public class ChangeObjects : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube;
    [SerializeField]
    private GameObject _sphere;
    [SerializeField]
    private GameObject _cylinder;
    [SerializeField]
    private GameObject _capsule;

    private Renderer _cubeRenderer;
    private Renderer _sphereRenderer;
    private Renderer _cylinderRenderer;
    private Renderer _capsuleRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _cubeRenderer = _cube.GetComponent<Renderer>();
        _sphereRenderer = _sphere.GetComponent<Renderer>();
        _cylinderRenderer = _cylinder.GetComponent<Renderer>();
        _capsuleRenderer = _capsule.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PaintToRed()
    {
        _cubeRenderer.material.color = Color.red;
        _sphereRenderer.material.color = Color.red;
        _cylinderRenderer.material.color = Color.red;
        _capsuleRenderer.material.color = Color.red;
    }

    public void PaintToGreen()
    {
        _cubeRenderer.material.color = Color.green;
        _sphereRenderer.material.color = Color.green;
        _cylinderRenderer.material.color = Color.green;
        _capsuleRenderer.material.color = Color.green;
    }

    public void PaintToBlue()
    {
        _cubeRenderer.material.color = Color.blue;
        _sphereRenderer.material.color = Color.blue;
        _cylinderRenderer.material.color = Color.blue;
        _capsuleRenderer.material.color = Color.blue;
    }
}
