using UnityEngine;
using System.Collections;

public class CreateEquipment : MonoBehaviour
{

	private BaseEquipment Equipment;
	private string[] itemNames = new string[4] {"Common", "Great", "Amazing", "Super"};
	// Use this for initialization
	void Start ()
	{
		CreateNewEquipment ();
		Debug.Log (Equipment.ItemN);
		Debug.Log (Equipment.ItemD);
		Debug.Log (Equipment.ItemID.ToString ());
		Debug.Log (Equipment.EquipmentType.ToString ());
		Debug.Log ("AStamina : " + Equipment.AStamina);
		Debug.Log ("AEndurance : " + Equipment.AEndurance);
		Debug.Log ("AIntellect : " + Equipment.AIntellect);
		Debug.Log ("AStrength : " + Equipment.AStrength);
	}
	public void CreateNewEquipment ()
	{
		Equipment = new BaseEquipment ();
		Equipment.ItemN = itemNames [Random.Range (1, 3)] + " Item";
		Equipment.ItemD = "The shiny Weapon Gleams with beauty";
		Equipment.ItemID = Random.Range (1, 101);
		Equipment.AStamina = Random.Range (1, 11);
		Equipment.AEndurance = Random.Range (1, 11);
		Equipment.AIntellect = Random.Range (1, 11);
		Equipment.AStrength = Random.Range (1, 11);
		ChooseEquipmentType ();
		Equipment.SpellEffectID = Random.Range (1, 101);
	}
	// Update is called once per frame
	private void ChooseEquipmentType ()
	{
		int randomTemp = Random.Range (1, 9);
		if (randomTemp == 1) {
			Equipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
		} else if (randomTemp == 2) {
			Equipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;
		} else if (randomTemp == 3) {
			Equipment.EquipmentType = BaseEquipment.EquipmentTypes.SHOULDERS;
		} else if (randomTemp == 4) {
			Equipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
		} else if (randomTemp == 5) {
			Equipment.EquipmentType = BaseEquipment.EquipmentTypes.FEET;
		} else if (randomTemp == 6) {
			Equipment.EquipmentType = BaseEquipment.EquipmentTypes.NECK;
		} else if (randomTemp == 7) {
			Equipment.EquipmentType = BaseEquipment.EquipmentTypes.EARRING;
		} else if (randomTemp == 8) {
			Equipment.EquipmentType = BaseEquipment.EquipmentTypes.RING;
		}
	}
}
