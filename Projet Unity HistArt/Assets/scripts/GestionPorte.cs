using UnityEngine;
using System.Collections;

public class GestionPorte : MonoBehaviour {

	GestionChaleur chaleur;
	float angleActuel;
	public float chaleurOuverture=50;


	// Use this for initialization
	void Start () {
		angleActuel = 0;
		chaleur = GetComponentInChildren<GestionChaleur>();
	}
	
	// Update is called once per frame
	void Update () {
		if(chaleur.chaleur > chaleurOuverture)
		{
			if(angleActuel<90)
			{
				transform.Rotate(0,-1,0);
				angleActuel++;
			}
		}
		else if(chaleur.chaleur < chaleurOuverture)
		{
			if(angleActuel>0)
			{
				transform.Rotate(0,1,0);
				angleActuel--;
			}
		}
	}


}
