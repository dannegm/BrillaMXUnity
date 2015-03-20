using UnityEngine;
using System.Collections;

public class Utils : MonoBehaviour {
	public static void HideInChild (Transform T) {
        Renderer[] rendererComponents = T.GetComponentsInChildren<Renderer>(true);
		Collider[] colliderComponents = T.GetComponentsInChildren<Collider>(true);
        foreach (Renderer component in rendererComponents) { component.enabled = false; }
		foreach (Collider component in colliderComponents) { component.enabled = false; }
	}
	public static void ShowInChild (Transform T) {
        Renderer[] rendererComponents = T.GetComponentsInChildren<Renderer>(true);
		Collider[] colliderComponents = T.GetComponentsInChildren<Collider>(true);
        foreach (Renderer component in rendererComponents) { component.enabled = true; }
		foreach (Collider component in colliderComponents) { component.enabled = true; }
	}
	public static void Hide (Transform T) {
        Renderer[] rendererComponents = T.GetComponents<Renderer>();
		Collider[] colliderComponents = T.GetComponents<Collider>();
        foreach (Renderer component in rendererComponents) { component.enabled = false; }
		foreach (Collider component in colliderComponents) { component.enabled = false; }
	}
	public static void Show (Transform T) {
        Renderer[] rendererComponents = T.GetComponents<Renderer>();
		Collider[] colliderComponents = T.GetComponents<Collider>();
        foreach (Renderer component in rendererComponents) { component.enabled = true; }
		foreach (Collider component in colliderComponents) { component.enabled = true; }
	}

	public static float Proporcional (float lado1, float lado2, float NuevoLado1) {
		float v1 = (lado2 / lado1) * NuevoLado1;
		v1 = Mathf.Round(v1 * 1f) / 1f;
		return v1;
	}
	public static float isOfPercent (float entero, float porcentaje) {
		return (entero / 100) * porcentaje;
	}
	public static float isPrecentOf (float entero, float extraido) {
		return (extraido / entero) * 100;
	}
	public static float is100pOf (float entero, float porcentaje) {
		return (entero * 100) / porcentaje;
	}
}