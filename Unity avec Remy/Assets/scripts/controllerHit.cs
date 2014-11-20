using UnityEngine;
using System.Collections;

public class controllerHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if (hit.normal.y < 0.9)
		{
			hit.gameObject.SendMessage("PlayerHit", hit, SendMessageOptions.DontRequireReceiver);
		}
	}
}
