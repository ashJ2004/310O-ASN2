using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class PantsOn : EquipmentItem.EquippedEffect
{
    StatSystem.StatModifier modifier = new StatSystem.StatModifier();
    public override void Equipped(CharacterData user)
     {
        modifier.ModifierMode = StatSystem.StatModifier.Mode.Absolute;
        modifier.Stats.defense = 7;

        user.Stats.AddModifier(modifier);
     }
     
     public override void Removed(CharacterData user)
     {
        user.Stats.RemoveModifier(modifier);
     }
}
