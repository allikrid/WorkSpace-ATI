using UnityEngine;
using System.Collections;

public class exercice3 : MonoBehaviour {
	public GameObject lancination;
	public float tempsrecharge;
	private float temps;

	// Use this for initialization
	void Start () {
		temps = 50f;
	}
	
	// Update is called once per frame
	void Update () {
		if (tempsrecharge <= temps) {
			if (Input.GetButton ("Fire1") || Input.GetButton("Fire2")) {
				GameObject lancinait;
				lancinait = Instantiate (lancination, transform.position, transform.rotation) as GameObject;
				lancinait.rigidbody.AddForce (Vector3.forward * 1000f);
				temps = 0f;
				Destroy(lancinait,3.5f);
			}
		} 
		else 
		{
			temps+=Time.deltaTime;	
		}
	}
}
