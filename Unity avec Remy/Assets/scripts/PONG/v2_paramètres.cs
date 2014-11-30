using UnityEngine;
using System.Collections;

public class v2_paramètres : MonoBehaviour {

	public GUIText GUIscoreJoueur;
	public GUIText GUIscoreOrdinateur;
	
	int score_joueur = 0;
	int score_ordinateur = 0;

	// Use this for initialization
	void Start () {
		score_joueur = score_ordinateur = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AjouterPoint(int joueur)
	{
		if (joueur < 1) 
		{
			score_joueur += 1;
		} 
		else
		{	
			score_ordinateur += 1;
		}
		RafraichirTexte ();
	}
	
	void RafraichirTexte()
	{
		GUIscoreJoueur.text = score_joueur.ToString();
		GUIscoreOrdinateur.text = score_ordinateur.ToString();
	}
}
