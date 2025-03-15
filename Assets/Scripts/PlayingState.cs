using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Concrete state class
/// PlayingState is a concrete state class that implements the IGameState interface.
/// </summary>
public class PlayingState : IGameState
{
    public void Handle()
    {
        Time.timeScale = 1; // Resume gameplay
        Debug.Log("Game is in Playing state.");
    }
}

