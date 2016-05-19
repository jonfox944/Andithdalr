using UnityEngine;
using System.Collections;

public class BaseItem
{
	private string itemN;
	private string itemD;

	private int itemID;

	public enum ItemTypes
	{
		EQUIPMENT,
		WEAPON,
		SCROLL,
		POTION,
		CHEST
	}

	private ItemTypes itemType;

	public string ItemN {
		get{ return itemN;}
		set{ itemN = value;}
	}

	public string ItemD {
		get{ return itemD;}
		set{ itemD = value;}
	}

	public int ItemID {
		get{ return itemID;}
		set{ itemID = value;}
	}
	public ItemTypes ItemType {
		get{ return itemType;}
		set{ itemType = value;}
	}
}
