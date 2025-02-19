using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class PantsOn : EquipmentItem.EquippedEffect
{
     public override void Equipped(CharacterData user)
     {
        user.Stats.baseStats.defense += 7;
     }
     
     public override void Removed(CharacterData user)
     {
        user.Stats.baseStats.defense -= 7;
     }
}
