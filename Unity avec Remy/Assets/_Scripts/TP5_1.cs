using UnityEngine;
using System.Collections;

public class TP5_1 : MonoBehaviour {

    private Vector3 posOrigin;

	// Use this for initialization
    void Start()
    {
        //Enregistré la position d'origine du cube dés son apparition
        posOrigin = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter()
    {
        //Créer un autre cube à la position d'origine de celui-ci
        Instantiate(gameObject, posOrigin, Quaternion.identity);
        //Détruire le cube.
        Destroy(gameObject);
    }
}
