using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class PPSerialise
{
	public static BinaryFormatter bf = new BinaryFormatter ();

	public static void Save (string sTag, object obj)
	{
		MemoryStream ms = new MemoryStream ();
		bf.Serialize (ms, obj);
		string temp = System.Convert.ToBase64String (ms.ToArray ());
		PlayerPrefs.SetString (sTag, temp);
	}

	public static object Load (string sTag)
	{
		string temp = PlayerPrefs.GetString (sTag);
		if (temp == string.Empty) {
			return null;
		}
		MemoryStream ms = new MemoryStream (System.Convert.FromBase64String (temp));
		return bf.Deserialize (ms);
	}
}
