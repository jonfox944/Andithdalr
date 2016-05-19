using UnityEngine;
using System.Collections;

public class BaseSkill
{

    // Use For All skills magic and melee
    // Damage over Time effects (DoT)
    // Healing Over Time Effect (HOT)
    //Area Of Effect (AoE)
    //Does trigger Global Cooldown + Timer
    private int range;
    private int cooldown;
    private int castTime;
#pragma warning disable CS0169 // The field 'BaseSkill.aoe' is never used
    private bool aoe;
#pragma warning restore CS0169 // The field 'BaseSkill.aoe' is never used
#pragma warning disable CS0169 // The field 'BaseSkill.dot' is never used
    private bool dot;
#pragma warning restore CS0169 // The field 'BaseSkill.dot' is never used
#pragma warning disable CS0169 // The field 'BaseSkill.hot' is never used
    private bool hot;
#pragma warning restore CS0169 // The field 'BaseSkill.hot' is never used

#pragma warning disable CS0169 // The field 'BaseSkill.targetRequired' is never used
    private bool targetRequired;
#pragma warning restore CS0169 // The field 'BaseSkill.targetRequired' is never used
    private int damage;
    private int heal;

    public enum spellEffects
        {
            leech,
            burn,
            freeze,
            disorentate,
            silence,
            root,
            stun,
            knockback
        }

    public int Range
    {
        get { return range; }
        set { range = value; }
    }
    public int Cooldown
    {
        get { return cooldown; }
        set { cooldown = value; }
    }
    public int CastTime
    {
        get { return castTime; }
        set { castTime = value; }
    }
    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }
    public int Heal
    {
        get { return heal; }
        set { heal = value; }
    }

}
