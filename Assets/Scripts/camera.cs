using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;       // Player transform
    public Vector3 offset;         // Camera offset from player
    public float smoothSpeed = 5f; // Smooth camera movement

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPos = target.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed * Time.deltaTime);

        transform.position = smoothedPos;
    }
}