using System;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Health bar that displays the health of the player.
/// </summary>
public class HealthBar : MonoBehaviour
{
    public Image fillImage;

    public void SetHealth(float healthPercentage)
    {
        fillImage.fillAmount = healthPercentage;
    }
}
