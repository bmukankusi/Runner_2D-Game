using UnityEngine;

/// <summary>
/// Background controller that follows the camera in the horizontal direction.
/// </summary>
public class BackgroundFollow : MonoBehaviour
{
    public Transform cameraTransform;

    void Update()
    {
        transform.position = new Vector3(cameraTransform.position.x, transform.position.y, transform.position.z);
    }
}
