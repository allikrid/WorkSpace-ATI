using UnityEngine;
using System.Collections;

public class controleJoueur : MonoBehaviour {
	bool debut_Partie;
	Vector3 PositionJoueurInitiale;
	public float valeurMax = 14;

	// Use this for initialization
	void Start () {
		if (!debut_Partie) 
		{
			PositionJoueurInitiale = transform.position;
			debut_Partie=true;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate()
	{
		Ray RayonVersPositionSouris = Camera.main.ScreenPointToRay (Input.mousePosition);
		transform.position = new Vector3 (PositionJoueurInitiale.x,
		                                  PositionJoueurInitiale.y,
		                                  Mathf.Clamp(RayonVersPositionSouris.GetPoint(PositionJoueurInitiale.y).z,-valeurMax,valeurMax));


	}
}
