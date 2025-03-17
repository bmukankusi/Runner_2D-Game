using System;
using UnityEngine;
using TMPro;

/// <summary>
/// This class is responsible for managing the score of the player.
/// </summary>

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }
}
