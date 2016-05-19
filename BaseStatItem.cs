using UnityEngine;
using System.Collections;

public class BaseStatItem : BaseItem
{

	private int baStamina;
	private int baEndurance;
	private int baStrength;
	private int baIntellect;

	public int AStamina {
		get{ return baStamina;}
		set{ baStamina = value;}
	}
	public int AEndurance {
		get{ return baEndurance;}
		set{ baEndurance = value;}
	}
	public int AStrength {
		get{ return baStrength;}
		set{ baStrength = value;}
	}
	public int AIntellect {
		get{ return baIntellect;}
		set{ baIntellect = value;}
	}
}
