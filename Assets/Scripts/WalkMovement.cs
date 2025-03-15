using System;
using UnityEngine;

public class WalkMovement : IMovementStrategy
{
    public void Move(Transform playerTransform)
    {
        playerTransform.Translate(Vector3.right * 2 * Time.deltaTime);
    }
}
