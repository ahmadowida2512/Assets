using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;     // اللاعب
    public Vector3 offset;       // فرق بين الكاميرا واللاعب
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
    }
}
