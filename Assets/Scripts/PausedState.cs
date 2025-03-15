using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Concrete state class
/// Paused state is a concrete state class that implements the IGameState interface.
/// </summary>
public class PausedState : IGameState
{
    public void Handle()
    {
        Time.timeScale = 0; // Pause game
        Debug.Log("Game is Paused.");
    }
}
