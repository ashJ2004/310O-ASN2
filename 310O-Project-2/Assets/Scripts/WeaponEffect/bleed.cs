using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class bleed : Weapon.WeaponAttackEffect
{
    public int bleedStacks = 0;
    public override void OnAttack(CharacterData target, CharacterData user, ref Weapon.AttackData attackData)
    {
        attackData.AddDamage(StatSystem.DamageType.Physical, bleedStacks * 4);
    }
    
    public override void OnPostAttack(CharacterData target, CharacterData user, Weapon.AttackData data)
    {
        user.Stats.ChangeHealth(bleedStacks);
        if(target.Stats.CurrentHealth <= 0)
        {
            bleedStacks = 0;
        }
        else
        {
            bleedStacks++;
        }
        
    }
}
