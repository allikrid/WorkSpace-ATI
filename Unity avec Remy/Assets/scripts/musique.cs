using UnityEngine;
using System.Collections;

public class musique : MonoBehaviour {
	public AudioClip[] sounds;
	// Use this for initialization
	void Start () {
		audio.clip = sounds[Random.Range(0, sounds.Length)];
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
		}
}
