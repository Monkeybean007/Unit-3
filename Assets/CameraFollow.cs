using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // Reference to the player's transform
    public float smoothSpeed = 0.125f;  // Speed of camera movement
    public Vector3 offset = new Vector3(0f, 2f, -5f);  // Offset from the player

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            transform.LookAt(target.position);  // Make the camera look at the player
        }
        else
        {
            Debug.LogWarning("Target not set for CameraFollow script. Please assign the player GameObject to the 'Target' field.");
        }
    }
}
