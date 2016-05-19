	using UnityEngine;
using System.Collections;
	
public class CreatePotion : MonoBehaviour
{
		
	private BasePotion Potion;
	private string[] itemNames = new string[4] {"Common", "Great", "Amazing", "Super"};
	// Use this for initialization
	void Start ()
	{
		CreateNewPotion ();
		Debug.Log (Potion.ItemN);
		Debug.Log (Potion.ItemD);
		Debug.Log (Potion.ItemID.ToString ());
		Debug.Log (Potion.PotionType.ToString ());
		Debug.Log ("AStamina : " + Potion.AStamina);
		Debug.Log ("AEndurance : " + Potion.AEndurance);
		Debug.Log ("AIntellect : " + Potion.AIntellect);
		Debug.Log ("AStrength : " + Potion.AStrength);
	}
	public void CreateNewPotion ()
	{
		Potion = new BasePotion ();
		Potion.ItemN = itemNames [Random.Range (1, 3)] + " Potion";
		Potion.ItemD = "The shiny Potion Gleams with Mystic";
		Potion.ItemID = Random.Range (1, 101);
		Potion.AStamina = Random.Range (1, 11);
		Potion.AEndurance = Random.Range (1, 11);
		Potion.AIntellect = Random.Range (1, 11);
		Potion.AStrength = Random.Range (1, 11);
		ChoosePotionType ();
		Potion.SpellEffectID = Random.Range (1, 101);
	}
	// Update is called once per frame
	private void ChoosePotionType ()
	{
		int randomTemp = Random.Range (1, 8);
		if (randomTemp == 1) {
			Potion.PotionType = BasePotion.PotionTypes.HEALTH;
		} else if (randomTemp == 2) {
			Potion.PotionType = BasePotion.PotionTypes.ENERGY;
		} else if (randomTemp == 3) {
			Potion.PotionType = BasePotion.PotionTypes.ENDURANCE;
		} else if (randomTemp == 4) {
			Potion.PotionType = BasePotion.PotionTypes.STRENGTH;
		} else if (randomTemp == 5) {
			Potion.PotionType = BasePotion.PotionTypes.INTERLLECT;
		} else if (randomTemp == 6) {
			Potion.PotionType = BasePotion.PotionTypes.SPEED;
		} else if (randomTemp == 7) {
			Potion.PotionType = BasePotion.PotionTypes.VITALITY;
		}
	}
}
