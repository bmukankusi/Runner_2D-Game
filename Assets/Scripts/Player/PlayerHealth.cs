using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Player health that keeps track of the player's health and updates the health bar.
/// </summary>
public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public Image healthBarFill; 

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Player Died!");
        }
        UpdateHealthUI();
    }

    // Update the health bar fill amount based on the current health
    private void UpdateHealthUI()
    {
        healthBarFill.fillAmount = (float)currentHealth / maxHealth;
    }
}
