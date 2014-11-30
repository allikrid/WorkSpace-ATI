using UnityEngine;
using System.Collections;

public class TP5_4 : MonoBehaviour
{

    public float jump = 10f;
    public Vector3 propulsionVector = new Vector3(1f, 1f, 0f);

    // Use this for initialization
    void Start()
    {
        //On ajoute une force au gameobject dés son apparition
        rigidbody.AddForce(propulsionVector * jump, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter()
    {
        //Dés l'entré en collision instantier un autre cube (une unité au dessus : Vector3.up)
        Instantiate(gameObject, transform.position + Vector3.up , Quaternion.identity);
        //Puis détruire l'object
        Destroy(gameObject);
    }
}
