using UnityEngine;
using System.Collections;

public class MenuPauseIG : MonoBehaviour {
	bool pause = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Escape"))
		{
			pause = !pause;
		}

		if (pause)
		{
			Time.timeScale = 0f;
		}
		else
		{
			Time.timeScale = 1f;
		}
	}

	void OnGUI ()
	{
		if(pause)
		{
			
			// Si le bouton est présser alors isPaused devient faux donc le jeu reprend.
			if(GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 - 20, 80, 40), "Continuer"))
			{
				pause = false;
			}
			
			// Si le bouton est présser alors on ferme completement le jeu ou charge la scene "Menu Principal
			// Dans le cas du bouton quitter il faut augmenter sa postion Y pour qu'il soit plus bas
			if(GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 + 40, 80, 40), "Quitter"))
			{
				//Application.Quit(); 
				Application.LoadLevel(0); 
				
			}
			
		}
	}
}
