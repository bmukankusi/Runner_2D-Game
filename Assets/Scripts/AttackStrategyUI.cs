using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// UI for selecting attack strategies.
/// Buttons for melee, ranged, and magic attacks.
/// </summary>
public class AttackStrategyUI : MonoBehaviour
{
    public PlayerAttack playerAttack;
    public Button meleeButton, rangedButton, magicButton;

    private void Start()
    {
        // Ensure the player attack script is assigned
        if (playerAttack == null)
        {
            playerAttack = FindObjectOfType<PlayerAttack>();
        }

        meleeButton.onClick.AddListener(() => playerAttack.SetAttackStrategy(new MeleeAttack()));
        rangedButton.onClick.AddListener(() => playerAttack.SetAttackStrategy(new RangedAttack()));
        magicButton.onClick.AddListener(() => playerAttack.SetAttackStrategy(new MagicAttack()));
    }
}
