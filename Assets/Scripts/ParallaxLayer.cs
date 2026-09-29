using UnityEngine;

public class ParallaxLayer : MonoBehaviour
{
    [Tooltip("0 = fica parado junto com a câmera (infinitamente longe). 1 = acompanha o mundo normalmente (sem parallax). >1 = mais rápido que a câmera (primeiro plano).")]
    [SerializeField] private float parallaxFactorX = 0.5f;
    [SerializeField] private float parallaxFactorY = 0f;

    private Transform cameraTransform;
    private Vector3 lastCameraPosition;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
    }

    private void LateUpdate()
    {
        Vector3 delta = cameraTransform.position - lastCameraPosition;
        transform.position += new Vector3(delta.x * parallaxFactorX, delta.y * parallaxFactorY, 0f);
        lastCameraPosition = cameraTransform.position;
    }
}
