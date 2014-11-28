using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class audioPing : MonoBehaviour {

	public AudioClip impact;
	void OnCollisionEnter() {
		audio.Play ();

}
}