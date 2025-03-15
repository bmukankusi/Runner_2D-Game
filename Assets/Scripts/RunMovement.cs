using System;
using UnityEngine;


/// <summary>
/// Concrete strategy for running movement.
/// Translates the player to the right.
/// </summary>
public class RunMovement : IMovementStrategy
{
    public void Move(Transform playerTransform)
    {
        playerTransform.Translate(Vector3.right * 5 * Time.deltaTime);
    }
}
