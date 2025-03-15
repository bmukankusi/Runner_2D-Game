using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{

    /// <summary>
    /// Singleton instance of the GameManager
    /// </summary>
    public static GameManager Instance { get; private set; }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Quits the game
    /// </summary>

    public void QuitGame()
    {
        Application.Quit();
    }
}
