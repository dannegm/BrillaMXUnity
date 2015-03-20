using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class UXHeader : MonoBehaviour {
	public GUIStyle BgHeader;
	public float Height;
	public float Width;

	private float w_width = 0f;
	private float w_height = 0f;

	private bool cacheSize = false;

	float n_width = 0;
	float n_height = 0;
	Rect r_header;

	void OnGUI () {
		if (w_width != Screen.width || w_height != Screen.height) {
			cacheSize = false;
		}

		if (!cacheSize) {
			w_width = Screen.width;
			w_height = Screen.height;
			cacheSize = true;
		}

		if (!cacheSize) {
			n_width = w_width;
			n_height = Utils.Proporcional (Width, Height, n_width);
			r_header = new Rect (0, 0, n_width, n_height);
		}
		GUI.Box (r_header, "", BgHeader);
	}
}
