using UnityEngine;
using System.Collections;

public class affichageBoutons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI ()
	{
			if(GUI.Button(new Rect(Screen.width / 2 - 120, Screen.height / 2 - 20, 100, 40), "Un joueur"))
			{
				Application.LoadLevel(2);
			}
			
			if(GUI.Button(new Rect(Screen.width / 2 + 20 , Screen.height / 2 - 20, 100, 40), "Deux joueurs"))
			{
				Application.LoadLevel(1);
			}
			
			if(GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 + 40, 80, 40), "Quitter"))
			{
				Application.Quit(); 
	
				
			}
			

	}
}
