using UnityEngine;
using System.Collections;

public class controleClavier : MonoBehaviour {
	public float valeurMax = 13.5f;
	public float vitesse = 20f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate()
	{
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += transform.forward * Time.deltaTime * vitesse;
		}
		else if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.position -= transform.forward * Time.deltaTime * vitesse;
		}
		transform.position = new Vector3(transform.position.x,0, Mathf.Clamp(transform.position.z, -valeurMax, valeurMax));
	}
}
