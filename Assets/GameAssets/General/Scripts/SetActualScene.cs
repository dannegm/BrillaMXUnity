using UnityEngine;
using System.Collections;

public class SetActualScene : MonoBehaviour {
	public string Scene;
	void Start () {
		PlayerPrefs.SetString ("actualScene", Scene);
	}
}
