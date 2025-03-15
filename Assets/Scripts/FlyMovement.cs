using UnityEngine;

public class FlyMovement : IMovementStrategy
{
    public void Move(Transform playerTransform)
    {
        playerTransform.Translate(Vector3.up * 3 * Time.deltaTime);
    }
}
