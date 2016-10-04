using UnityEngine;
using System.Collections;

public class BaseMagicSkill : BaseSkill
{
    // Magic Ability Creator

    // Damage over Time effects (DoT)
    //if true require dOTID
    //if false apply flat damage

    // Healing Over Time Effect (HOT)
    //if true require hOTID
    //if false apply flat hp inscrease

    //Area Of Effect (AoE)
    //private Bool AOE
    //if true require radius
    //if false cast only on target

    //Require target
    //if true require enemy target 
    //else if (heal) self-cast
    //else if false show projected texture (PtEXTID)


    //Cast timer
    //is instant cast
    //if true cast
    //else if false apply spell cast timer (spellCastID)

    //damage on hit
    //apply only to spell effect 1-9, affected by intellect for mana based attacks affected by strength for physical attacks.

    //Instant heal
    //increase hp by SpellID affected by intellect

    //Cooldown
    //Is Spell on GCD if true apply 2 sec CD 
    //else if apply spell specific cooldown

    //Special effect such as leech
    //does spell have effect
    //if true apply SpellEFFECTID
    //else if apply SpellEFFECTID 0 = no effect

    //Range
    //spell castable range
    //min range
    //max range
	
}
