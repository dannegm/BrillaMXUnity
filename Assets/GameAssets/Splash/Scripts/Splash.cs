using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {

	public string FirstScene;
	public float TimeToIntro;

	private float timeInit;
	void Start () {
		timeInit = Time.time;
		PlayerPrefs.GetString ("actualScene", FirstScene);
	}
	void Update () {
		if (Time.time > (timeInit + TimeToIntro)) {
			Application.LoadLevel(FirstScene);
		}
	}
}
