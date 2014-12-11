using UnityEngine;
using System.Collections;

public class GestionChaleur2 : MonoBehaviour {

	public float maxChaleur;
	public float chaleur;
	public float perdition;

	float temps;

	// Use this for initialization
	void Start () {
		temps = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		temps += Time.deltaTime;
		if (temps > 1) 
		{
			temps=0;
			if (chaleur>0)
			{
				chaleur -= perdition;
			}
			else chaleur = 0;
		}
	}
}
