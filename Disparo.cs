//Nombre: Melissa Estela Oscoy Parada 
//Profesor: Josue Israel Rivas Diaz
//Materia: Estructura de Datos 
//Práctica: shooting tank
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Rigidbody bullet;
    public Transform Cañon;
    public float fuerzaDisparo;

   
    //este script se hace para configurar un boton para que accionara un disparo
    //se le pone fuerza y velocidad a la bala
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody bulletPos = Instantiate(bullet, Cañon.position, Cañon.rotation)as Rigidbody;

            bulletPos.AddForce(Cañon.forward * fuerzaDisparo);
        }
    }
}
