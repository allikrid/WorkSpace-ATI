using UnityEngine;
using System.Collections;

public class GestionChaleur : MonoBehaviour {

	public float maxChaleur=100;
	public float chaleur=0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (chaleur > maxChaleur)
			chaleur = maxChaleur;

		else if (chaleur < 0)
			chaleur = 0;
	}
}