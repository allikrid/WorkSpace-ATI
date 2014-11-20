using UnityEngine;
using System.Collections;

public class teleportation : MonoBehaviour {
	public GameObject destination;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void PlayerHit(ControllerColliderHit hit){
		GameObject joueur = GameObject.Find("joueur");
		GameObject destination2 = destination.transform.GetChild(0).gameObject;
		float posY = joueur.transform.position.y;
		joueur.transform.position = destination2.transform.position + destination2.transform.forward;
		joueur.transform.position = new Vector3 (joueur.transform.position.x, posY, joueur.transform.position.z);
		joueur.transform.rotation = destination2.transform.rotation;
	}
}
