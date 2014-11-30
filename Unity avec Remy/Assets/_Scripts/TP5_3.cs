using UnityEngine;
using System.Collections;

public class TP5_3 : MonoBehaviour {

    public GameObject cube; //On crée une variable publique on l'on stoquera notre prefab

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space))
            Instantiate(cube, transform.position, Quaternion.identity);
	}
}
