using UnityEngine;


/// <summary>
/// Melee attack strategy.
/// Melee Attack inherits from IAttackStrategy.
/// </summary>
public class MeleeAttack : IAttackStrategy
{
    public void ExecuteAttack()
    {
        Debug.Log("Performing a melee attack!");
    }
}
