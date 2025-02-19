using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class SpeedBoost : UsableItem.UsageEffect
{
    public float Duration = 10.0f;
    public int SpeedChange = 2;
    public Sprite EffectSprite;
    public override bool Use(CharacterData user)
    {
        
        StatSystem.StatModifier modifier = new StatSystem.StatModifier();
        modifier.ModifierMode = StatSystem.StatModifier.Mode.Absolute;
        user.Stats.baseStats.agility *= SpeedChange;

        user.Stats.AddTimedModifier(modifier, Duration, "SpeedAdd", EffectSprite);
        return true;
    }
}
