using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour
{

	void Awake ()
	{
		DontDestroyOnLoad (transform.gameObject);
	}
	public static string PlayerName{ get; set; }
	public static int PlayerLevel{ get; set; }
	public static BaseCC PlayerClass{ get; set; }

	public static int Stamina{ get; set; }
	public static int Endurance{ get; set; }
	public static int Intellect{ get; set; }
	public static int Strength{ get; set; }


	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
