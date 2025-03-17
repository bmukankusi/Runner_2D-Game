using UnityEngine;

/// <summary>
/// Ranged attack strategy. Inherits from IAttackStrategy.
/// Calls the ExecuteAttack method to perform a ranged attack.
/// returns void
/// </summary>
public class RangedAttack : IAttackStrategy
{
    public void ExecuteAttack()
    {
        Debug.Log("Performing a ranged attack!");
    }
}
