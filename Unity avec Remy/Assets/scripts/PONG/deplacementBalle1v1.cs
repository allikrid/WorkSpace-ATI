using UnityEngine;
using System.Collections;

public class deplacementBalle1v1 : MonoBehaviour {
	Vector3 direction;
	float vitesse;
	
	public float vitesseInitiale = 10f;
	public float acceleration = 2f;
	
	public AudioClip sonCollision;
	public AudioClip sonGoal;
	
	// Use this for initialization
	void Start () {
		float X = Random.Range (-1f, 1f);
		float Z = Random.Range (-1f, 1f);
		if (X > 0) {
			if (Z > 0)
				direction = new Vector3 (1f, 0, Random.Range (1.5f, 3f));
			else
				direction = new Vector3 (1f, 0, Random.Range (-3f,-1.5f));
		}
		else
		{
			if (Z > 0)
				direction = new Vector3 (-1f, 0, Random.Range (1.5f, 3f));
			else
				direction = new Vector3 (-1f, 0, Random.Range (-3f,-1.5f));
		}
		
		vitesse = vitesseInitiale;
		transform.position = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void FixedUpdate()
	{
		this.transform.position += direction * vitesse * Time.deltaTime;
		
		if (transform.position.x < -25)
		{
			GameObject.Find ("Main Camera").GetComponent<Parametres1v1> ().AjouterPoint (1);
			audio.PlayOneShot(sonGoal);
			Start();
			
		}
		else if (transform.position.x > 25)
		{
			GameObject.Find ("Main Camera").GetComponent<Parametres1v1> ().AjouterPoint (0);
			audio.PlayOneShot(sonGoal);
			Start();
		}
	}
	
	void OnCollisionEnter(Collision collider)
	{
		Vector3 normal = collider.contacts [0].normal;
		direction = Vector3.Reflect (direction, normal);
		
		if (collider.gameObject.tag == "Mur") 
		{
			
		}
		else if (collider.gameObject.tag == "Raquette")
		{
			vitesse += acceleration;
		}
		audio.PlayOneShot(sonCollision);
	}
}
