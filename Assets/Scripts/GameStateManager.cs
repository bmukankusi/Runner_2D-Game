using System;
using System.Collections;
using UnityEngine;

/// <summary>
/// Concrete state class
/// Calling this class will pause, resume, or change the state of the game.
/// </summary>
public class GameStateManager : MonoBehaviour
{
    // Reference to the current state of the game
    private IGameState currentState;

    public void SetState(IGameState state)
    {
        currentState = state;
        currentState.Handle();
    }

    public void PauseGame()
    {
        SetState(new PausedState());
    }

    public void ResumeGame()
    {
        SetState(new PlayingState());
    }
}
