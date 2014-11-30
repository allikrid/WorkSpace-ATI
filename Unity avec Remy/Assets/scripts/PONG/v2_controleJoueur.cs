using UnityEngine;
using System.Collections;

public class v2_controleJoueur : MonoBehaviour {
	Vector3 PositionJoueurInitiale;
	public float LimitesTerrain = 7f;
	public float vitesse = 50f;

	// Use this for initialization
	void Start () {
		PositionJoueurInitiale = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate()
	{

		if(Input.GetKey(KeyCode.Q))
		{
			transform.position -= Vector3.right*vitesse*Time.deltaTime;
		}
		else if(Input.GetKey(KeyCode.D))
		{
			transform.position += Vector3.right*vitesse*Time.deltaTime;
		}
		if(Mathf.Abs(transform.position.x)>LimitesTerrain)
			transform.position = new Vector3(Mathf.Clamp(transform.position.x,-LimitesTerrain,LimitesTerrain),0,PositionJoueurInitiale.z);
	}
}
