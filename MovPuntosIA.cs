//Nombre: Melissa Estela Oscoy Parada 
//Profesor: Josue Israel Rivas Diaz
//Materia: Estructura de Datos 
//Titulo: enemies movements
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemigoIA
{
    Patrulla,
    Perseguir,
    Atacar

}

//esto sirve para que podamos mover a "enemigos u objetos" en una secuencia y tambien para 
//que pueda hacer diferentes patrones de seguimiento

public class MovPuntosIA : MonoBehaviour
//esta practica sirve para dar una secuencia de movimiento de
//punto a punto a un objeto
{
    public float velocidad;
    public Transform sierra;
    public Transform[] puntos;
    public Transform target;
    public int indicetarget;
    public Transform player;
    public EnemigoIA estadoActual = new EnemigoIA();

    // Start is called before the first frame update
    void Start()
    {
        estadoActual = EnemigoIA.Patrulla;
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
        float distancePlayer = Vector3.Distance(sierra.position, player.position);

        sierra.Translate(dir.normalized * velocidad, Space.World);
        if (estadoActual == EnemigoIA.Patrulla)
        {
            target = puntos[indicetarget];
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

        if (distancePlayer <= 2)
        {
            estadoActual = EnemigoIA.Perseguir;
        }
        else if (distancePlayer > 5)
            if (estadoActual == EnemigoIA.Perseguir)
            {
                target = player;
            }


    }
}