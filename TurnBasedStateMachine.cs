using UnityEngine;
using System.Collections;

public class TurnBasedStateMachine : MonoBehaviour
{

	public enum BattleStates
	{
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		LOSE,
		WIN
	}

	private BattleStates currentState;

	// Use this for initialization
	void Start ()
	{
		currentState = BattleStates.START;
	}
	
	// Update is called once per frame
	void Update ()
	{
		switch (currentState) {
		case (BattleStates.START):
			Debug.Log ("Welcome to HBD!!");
			break;
		case (BattleStates.PLAYERCHOICE):
			Debug.Log ("Choose your Move");
			break;
		case (BattleStates.ENEMYCHOICE):
			Debug.Log ("Enemy Moves");
			break;
		case (BattleStates.LOSE):
			Debug.Log ("Suffering is Futile");
			break;
		case (BattleStates.WIN):
			Debug.Log ("Victory over Death");
			break;
		}
	}

	void OnGUI ()
	{
		if (GUILayout.Button ("Next State >>>>")) {
			if (currentState == BattleStates.START) {
				currentState = BattleStates.PLAYERCHOICE;
			} else if (currentState == BattleStates.PLAYERCHOICE) {
				currentState = BattleStates.ENEMYCHOICE;
			} else if (currentState == BattleStates.ENEMYCHOICE) {
				currentState = BattleStates.LOSE;
			} else if (currentState == BattleStates.LOSE) {
				currentState = BattleStates.WIN;
			} else if (currentState == BattleStates.WIN) {
				currentState = BattleStates.START;
			}
		}
	}

}
