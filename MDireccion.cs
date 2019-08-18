//Autor: Melissa Estela Oscoy Parada
//Materia: Estructura de datos 
//Profesor: Josue Israel Rivas Diaz
//Practica: Disparo de tanque

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MDireccion : MonoBehaviour
{
    float Velocidad;
    Transform Objetivo; // <- variables goblales
    // Start is called before the first frame update
    void Start()
    {
        Velocidad = 0.5f;
        Objetivo = GameObject.Find("target").GetComponent<Transform>();
        Debug.Log(Objetivo.name);
        Vector3 dir = Objetivo.position - this.transform.position;
        Debug.Log(dir.magnitude >= 16);

        //esta es una variable local
        //El find -como su nombre lo dice- encuentra un objeto en la escena 
        //el GetComponent es para  leer un componente que pertenece al objeto
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Objetivo.position - this.transform.position;
        if (dir.magnitude >1 )
        {
            this.transform.Translate(dir.normalized * Velocidad, Space.World);
        }
        
    }
}
