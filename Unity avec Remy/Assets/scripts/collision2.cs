using UnityEngine;
using System.Collections;

public class collision2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionExit(Collision collision)
	{
		GameObject Salutation = collision.collider.gameObject;
		Salutation.rigidbody.AddForce (Vector3.up * 500f);
	}
}
