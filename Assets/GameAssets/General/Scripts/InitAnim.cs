using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class InitAnim : MonoBehaviour {
	public bool Loop;
	public bool PlayOnAwake;
	public string[] Anims;
	public bool isPlaying;

	void Awake () {
		if (PlayOnAwake) { Play(); }
	}
	void Update () {
		if (Loop) { Play(); }
		isPlaying = animation.isPlaying;
	}
	public void Play () {
		foreach (string Anim in Anims) { if (!animation.IsPlaying(Anim)) { animation.Play(Anim); } }
	}
}
