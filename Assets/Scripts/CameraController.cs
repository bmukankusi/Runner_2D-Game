using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;  
    public float smoothSpeed = 0.125f;  
    public Vector3 offset;  // Offset to adjust camera position

    void LateUpdate()
    {
        if (player != null)
        {
            // Follow the player in the horizontal and vertical direction
            Vector3 targetPosition = new Vector3(player.position.x + offset.x, player.transform.position.y + offset.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
        }
    }
}
