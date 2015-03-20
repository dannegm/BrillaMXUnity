using UnityEngine;
using System.Collections;

public class AudioControler : MonoBehaviour {
	public AudioSource[] Audios;
	public void Play () {
		foreach (AudioSource a in Audios) {
			a.Play();
		}
	}
	public void Stop () {
		foreach (AudioSource a in Audios) {
			a.Stop();
		}
	}
	public void Pause () {
		foreach (AudioSource a in Audios) {
			a.Pause();
		}
	}
}
