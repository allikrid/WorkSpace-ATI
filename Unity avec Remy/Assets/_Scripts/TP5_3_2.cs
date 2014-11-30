using UnityEngine;
using System.Collections;

public class TP5_3_2 : MonoBehaviour {

    public float jump = 10f;

	// Use this for initialization
	void Start () {
	    //On ajoute une force au gameobject dés son apparition
        rigidbody.AddForce(Vector3.right * jump, ForceMode.Impulse);
        //ON détruit l'object aprés 3 secondes
        Destroy(gameObject, 3f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
