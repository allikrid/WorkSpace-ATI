using UnityEngine;
using System.Collections;

public class exercice4 : MonoBehaviour {
	public float tempsrecharge;
	private float temps;
	// Use this for initialization
	void Start () {
		temps = 100f;
	}
	
	// Update is called once per frame
	void Update () {
		temps+=Time.deltaTime;	
	}

	void OnCollisionEnter(Collision collision)
	{
		if (tempsrecharge <= temps) {
				GameObject lancinait;
				lancinait = Instantiate (collision.collider.gameObject, transform.position, transform.rotation) as GameObject;
				lancinait.rigidbody.AddForce (Vector3.up * 1000f);
				temps = 0f;
				Destroy(lancinait,3.5f);
		} 
	}
}
