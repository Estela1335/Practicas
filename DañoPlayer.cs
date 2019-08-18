//Nombre: Melissa Estela Oscoy Parada 
//Profesor: Josue Israel Rivas Diaz
//Materia: Estructura de Datos 
//Titulo: Damage player

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//esto nos funciona para que cuando un objeto choque con el jugador este baje la vida del jugador
public class DañoPlayer : MonoBehaviour
{
    Vida vidajugador;

    void Start()
    {
        vidajugador = GameObject.Find("sprite").GetComponent<Vida>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.tag== "sprite")
        {
            vidajugador.vida -= 3;
        }
    }

    
}
