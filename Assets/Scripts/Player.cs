using System;
using System.Collections;
using UnityEngine;


/// <summary>
/// Set the movement strategy for the player.
/// </summary>
public class Player : MonoBehaviour
{
    private IMovementStrategy movementStrategy;

    void Update()
    {
        if (movementStrategy != null)
            movementStrategy.Move(transform);
    }

    public void SetMovementStrategy(IMovementStrategy strategy)
    {
        movementStrategy = strategy;
    }
}
