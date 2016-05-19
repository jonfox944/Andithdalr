﻿using UnityEngine;
using System.Collections;

public class BaseCC
{
	private string className;
	private string classDescription;

	private int stamina;
	private int endurance;
	private int strength;
	private int intellect;

	public string ClassName {
		get{ return className;}
		set{ className = value;}
	}
	public string ClassDescription {
		get{ return classDescription;}
		set{ classDescription = value;}
	}
	public int Stamina {
		get{ return stamina;}
		set{ stamina = value;}
	}
	public int Endurance {
		get{ return endurance;}
		set{ endurance = value;}
	}
	public int Strength {
		get{ return strength;}
		set{ strength = value;}
	}
	public int Intellect {
		get{ return intellect;}
		set{ intellect = value;}
	}
}