using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 90f; // درجة/الثانية

    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
}
}