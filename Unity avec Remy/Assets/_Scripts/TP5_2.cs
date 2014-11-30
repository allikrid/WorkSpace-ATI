using UnityEngine;
using System.Collections;

public class TP5_2 : MonoBehaviour {

    public float jump = 10f;

    private Vector3 posOrigin;

	// Use this for initialization
	void Start () {
        //Enregistré la position d'origine du cube dés son apparition
        posOrigin = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerExit()
    {
        //Créer un autre cube à la position d'origine de celui-ci
        Instantiate(gameObject, posOrigin, Quaternion.identity);
        //Ajouter une force à notre cube pour qu'il saute
        rigidbody.AddForce(-Vector3.forward * jump, ForceMode.Impulse);
        //Détruire le cube aprés 3 secondes.
        Destroy(gameObject, 3f);
    }
}
