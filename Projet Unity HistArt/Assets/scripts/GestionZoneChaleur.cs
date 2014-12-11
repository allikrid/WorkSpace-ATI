using UnityEngine;
using System.Collections;

public class GestionZoneChaleur : MonoBehaviour {
	
	public float variation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerStay(Collider other) {
		if(other.gameObject.GetComponent<GestionChaleur> ())
		{
			other.gameObject.GetComponent<GestionChaleur> ().chaleur += variation*Time.deltaTime;
		}
		
	}
}
