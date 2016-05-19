using UnityEngine;
using System.Collections;

public class CreateWeapon : MonoBehaviour
{

	private BaseWeapon Weapon;
	// Use this for initialization
	void Start ()
	{
		CreateNewWeapon ();
		Debug.Log (Weapon.ItemN);
		Debug.Log (Weapon.ItemD);
		Debug.Log (Weapon.ItemID.ToString ());
		Debug.Log (Weapon.WeaponType.ToString ());
		Debug.Log ("AStamina : " + Weapon.AStamina);
		Debug.Log ("AEndurance : " + Weapon.AEndurance);
		Debug.Log ("AIntellect : " + Weapon.AIntellect);
		Debug.Log ("AStrength : " + Weapon.AStrength);
	}
	public void CreateNewWeapon ()
	{
		Weapon = new BaseWeapon ();
		Weapon.ItemN = "Weapon Classed #" + Random.Range (1, 101);
		Weapon.ItemD = "The shiny Weapon Gleams with beauty";
		Weapon.ItemID = Random.Range (1, 101);
		Weapon.AStamina = Random.Range (1, 11);
		Weapon.AEndurance = Random.Range (1, 11);
		Weapon.AIntellect = Random.Range (1, 11);
		Weapon.AStrength = Random.Range (1, 11);
		ChooseWeaponType ();
		Weapon.SpellEffectID = Random.Range (1, 101);
	}
	// Update is called once per frame
	private void ChooseWeaponType ()
	{
		int randomTemp = Random.Range (1, 7);
		if (randomTemp == 1) {
			Weapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
		} else if (randomTemp == 2) {
			Weapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
		} else if (randomTemp == 3) {
			Weapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
		} else if (randomTemp == 4) {
			Weapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		} else if (randomTemp == 5) {
			Weapon.WeaponType = BaseWeapon.WeaponTypes.SHILED;
		} else if (randomTemp == 6) {
			Weapon.WeaponType = BaseWeapon.WeaponTypes.POLEARM;
		}
	}
}
