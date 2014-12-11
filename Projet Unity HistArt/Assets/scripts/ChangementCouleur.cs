using UnityEngine;
using System.Collections;

public class ChangementCouleur : MonoBehaviour {
	GestionChaleur chaleur;
	public Color[] tab_Couleurs;
	public float[] tab_Paliers;

	// Use this for initialization
	void Start () {
		chaleur = GetComponent<GestionChaleur>();
	}
	
	// Update is called once per frame
	void Update () {
		for (int i=tab_Paliers.Length-1; i>=0 ; i--)
		{
			if(chaleur.chaleur>=tab_Paliers[i])
			{
				gameObject.renderer.material.color = tab_Couleurs[i];
				break;
			}
		}
	}
}
