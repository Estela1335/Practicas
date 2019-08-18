//Autor: Melissa Estela Oscoy Parada
//Materia: Estructura de datos 
//Profesor: Josue Israel Rivas Diaz
//Practica: Movimiento de puntos

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//sirve para que un objeto se mueva por puntos seleccionados o creados
public class MovPuntos : MonoBehaviour

//esta practica es para aprender a darle una secuencia de movimiento tipo
//punto a punto a un objeto
{
    public float velocidad;
    public Transform sierra;
    public Transform[] puntos;
    public Transform target;
    public int indicetarget;
    

    void Start()
    {
        target = puntos[1];
        sierra.position = target.position;
        velocidad = velocidad * Time.deltaTime;
        indicetarget = 0;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - sierra.position;

        float distance = Vector3.Distance(sierra.position, target.position);

        sierra.Translate(dir.normalized * velocidad, Space.World);

        if (distance <= 0.5f)

        {
            if (indicetarget >= puntos.Length - 1)
            {
                indicetarget = 0;
                target = puntos[indicetarget];
            }
            indicetarget++;
            target = puntos[indicetarget];
        }


    }
}
