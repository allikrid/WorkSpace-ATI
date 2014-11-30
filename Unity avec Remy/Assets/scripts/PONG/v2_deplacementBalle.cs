using UnityEngine;
using System.Collections;

public class v2_deplacementBalle : MonoBehaviour {

	Vector3 direction;
	float vitesse;

	public float vitesseInitiale;
	public float acceleration;

	public AudioClip sonCollision;
	public AudioClip sonGoal;

	public float limitesX=9;
	public float limitesZ=25;

	// Use this for initialization
	void Start () {
		direction = new Vector3 (Random.Range(-2f,2f), 0, -2f);
		vitesse = vitesseInitiale;
		transform.position = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate()
	{
		transform.position += direction * vitesse * Time.deltaTime;

		if (transform.position.x > limitesX) 
		{
			direction.x = -direction.x;
			transform.position = new Vector3(limitesX,0,transform.position.z);
		}
		else if(transform.position.x < -limitesX)
		{
			direction.x = -direction.x;
			transform.position = new Vector3(-limitesX,0,transform.position.z);
		}

		else if (transform.position.z < -limitesZ)
		{
			GameObject.Find ("Main Camera").GetComponent<v2_paramètres> ().AjouterPoint(1);
			audio.PlayOneShot(sonGoal);
			Start();
			
		}
		else if (transform.position.z > limitesZ)
		{
			GameObject.Find ("Main Camera").GetComponent<v2_paramètres> ().AjouterPoint(0);
			audio.PlayOneShot(sonGoal);
			Start();
		}
	}
}
