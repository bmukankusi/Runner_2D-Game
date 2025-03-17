using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Magic attack strategy. Inherits from IAttackStrategy.
/// Calls the ExecuteAttack method to perform a magic attack.
/// <return>void</return>
/// </summary>
public class MagicAttack : IAttackStrategy
{
    public void ExecuteAttack()
    {
        Debug.Log("Casting a magic spell!");
    }
}
