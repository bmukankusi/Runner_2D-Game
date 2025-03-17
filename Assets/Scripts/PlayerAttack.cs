using System;
using UnityEngine;

/// <summary>
/// Player attack script that uses the strategy pattern.
/// </summary>
public class PlayerAttack : MonoBehaviour
{
    private IAttackStrategy attackStrategy;

    private void Start()
    {
        // Default attack strategy
        attackStrategy = new MeleeAttack();
    }

    public void SetAttackStrategy(IAttackStrategy newStrategy)
    {
        attackStrategy = newStrategy;
        Debug.Log("Attack strategy changed to: " + newStrategy.GetType().Name);
    }

    public void Attack()
    {
        if (attackStrategy != null)
        {
            attackStrategy.ExecuteAttack();
        }
    }
}
