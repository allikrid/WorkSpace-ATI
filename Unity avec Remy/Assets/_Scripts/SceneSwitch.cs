using UnityEngine;
using System.Collections;

public class SceneSwitch : MonoBehaviour {

    public int currentScene; //stocké le numero de la scéne dans une variable publique

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //Si on appuie sur la touche gauche
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            //allé vers la scéne précédente, on soustrait 1
            currentScene = currentScene - 1;
            //si on est sur la scéne 1 on passe à la scene 4 étant donné qu'il n y a pas de scene 0
            if (currentScene < 1)
                currentScene = 4;
            //on utilise (currentScene-1), car la fonction LoadLevel prend l'index de la scene, l'index de la scene 1 est 0, celui de la scene 2 est 1 etc..
            Application.LoadLevel(currentScene-1);
        } 
        
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            //allé vers la scéne suivant, on incrément de 1
            currentScene = currentScene + 1;
            //si on est sur la scéne 4 on passe à la scene 1 étant donné qu'il n y a pas de scene 5
            if (currentScene > 4)
                currentScene = 1;
            Application.LoadLevel(currentScene-1);
        }

        //Si le joueur appuie sur la touche echappe, on quitte le jeu
        if (Input.GetKeyUp(KeyCode.Escape))
            Application.Quit();
	}
}
