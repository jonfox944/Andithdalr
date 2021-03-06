﻿using UnityEngine;
using System.Collections;

public class BasePlayer
{
	private string playerName;
	private int playerLevel;
	private BaseCC playerClass;
	
	private int stamina;
	private int endurance;
	private int strength;
	private int intellect;
	
	public string PlayerName {
		get{ return playerName;}
		set{ playerName = value;}
	}
	public int PlayerLevel {
		get{ return playerLevel;}
		set{ playerLevel = value;}
	}
	public BaseCC PlayerClass {
		get{ return playerClass;}
		set{ playerClass = value;}
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