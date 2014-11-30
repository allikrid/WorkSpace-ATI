using UnityEngine;
using System.Collections;

public class controleOrdinateur : MonoBehaviour {

	public float vitesse=25f;
	public float valeurMax = 14;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void FixedUpdate()
	{
		GameObject balle = TrouverBalleLaPlusProche ();
		if (transform.position.z < balle.transform.position.z)
			transform.position += new Vector3(0, 0, Mathf.Min (vitesse*Time.deltaTime, balle.transform.position.z - transform.position.z));
		else if(transform.position.z > balle.transform.position.z)
			transform.position -= new Vector3(0, 0, Mathf.Min (vitesse*Time.deltaTime,transform.position.z-balle.transform.position.z));

		transform.position = new Vector3(transform.position.x,transform.position.y,Mathf.Clamp (transform.position.z, -valeurMax, valeurMax));
	}

	GameObject TrouverBalleLaPlusProche()
	{
		GameObject[] balles;
		balles = GameObject.FindGameObjectsWithTag("Balle");

		float positionX = balles[0].transform.position.x;
		GameObject balleLaPlusProche = balles[0];
		if (balles.Length > 1) 
		{
			foreach (GameObject balle in balles) {
				if (positionX < balle.transform.position.x)
				{
					positionX = balle.transform.position.x;
					balleLaPlusProche = balle;
				}
			}
		}
		return balleLaPlusProche;
	}

}
