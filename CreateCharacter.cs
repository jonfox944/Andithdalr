using UnityEngine;
using System.Collections;

public class CreateCharacter : MonoBehaviour
{
	private BasePlayer Player;
	private bool isMageClass;
	private bool isWarriorClass;
    private bool IsRangerClass;
    private bool IsPriestClass;
    private bool IsRogueClass;
    private bool IsStrikerClass;
    private bool IsCustomClass;
    private string playerName = "EnterHere";

	void Start ()
	{
		Player = new BasePlayer ();
	
	}
	void Update ()
	{

	}

	void OnGUI ()
	{
		playerName = GUILayout.TextArea (playerName, 15);
		isMageClass = GUILayout.Toggle (isMageClass, "Mage Class");
		isWarriorClass = GUILayout.Toggle (isWarriorClass, "Warrior Class");
        IsRangerClass = GUILayout.Toggle(IsRangerClass, "Ranger Class");
        IsPriestClass = GUILayout.Toggle(IsPriestClass, "Priest Class");
        IsStrikerClass = GUILayout.Toggle(IsStrikerClass, "Striker Class");
        IsRogueClass = GUILayout.Toggle(IsRogueClass, "Rogue");
        IsCustomClass = GUILayout.Toggle(IsCustomClass, "Full Role Player Class Creation");
        if (GUILayout.Button ("Create")) {
			if (isMageClass) {
				Player.PlayerClass = new BaseWizard ();
			} else if (isWarriorClass) {
				Player.PlayerClass = new BaseWarrior ();
                Player.PlayerClass = new BaseRanger();
                Player.PlayerClass = new BasePriest();
                Player.PlayerClass = new BaseRogue();
                Player.PlayerClass = new BaseStriker();
                Player.PlayerClass = new CustomClass();
            }

			Player.PlayerLevel = 1;
			Player.Stamina = Player.PlayerClass.Stamina;
			Player.Endurance = Player.PlayerClass.Endurance;
			Player.Intellect = Player.PlayerClass.Intellect;
			Player.Strength = Player.PlayerClass.Strength;
			Player.PlayerName = playerName;

			StoreNewPlayerInformation ();
			SaveInformation.SaveAllInformation ();

			Debug.Log ("Player Name :" + Player.PlayerName);
			Debug.Log ("Player Class :" + Player.PlayerClass.ClassName);
			Debug.Log ("Player Description :" + Player.PlayerClass.ClassDescription);
			Debug.Log ("Player Level :" + Player.PlayerLevel);
			Debug.Log ("Player Stamina :" + Player.PlayerClass.Stamina);
			Debug.Log ("Player Endurance :" + Player.PlayerClass.Endurance);
			Debug.Log ("Player Intellect :" + Player.PlayerClass.Intellect);
			Debug.Log ("Player Strength :" + Player.PlayerClass.Strength);
		}
		if (GUILayout.Button ("Load")) {
#pragma warning disable CS0618 // 'Application.LoadLevel(int)' is obsolete: 'Use SceneManager.LoadScene'
			Application.LoadLevel (1);
#pragma warning restore CS0618 // 'Application.LoadLevel(int)' is obsolete: 'Use SceneManager.LoadScene'
		}
	}

	private void StoreNewPlayerInformation ()
	{
		GameInformation.PlayerLevel = Player.PlayerLevel;
		GameInformation.PlayerName = Player.PlayerName;
		GameInformation.Stamina = Player.Stamina;
		GameInformation.Endurance = Player.Endurance;
		GameInformation.Intellect = Player.Intellect;
		GameInformation.Strength = Player.Strength;

	}
}
