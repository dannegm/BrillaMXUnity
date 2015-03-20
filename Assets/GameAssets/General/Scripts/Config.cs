using UnityEngine;
using System.Collections;

public class Config : MonoBehaviour {
	public static void set (string Key, string Value) {
		PlayerPrefs.SetString (Key, Value);
	}
	public static string get (string Key, string Value) {
		return PlayerPrefs.GetString (Key, Value);
	}
}
