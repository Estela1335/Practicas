using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{
    TurretD torrtaRadar;
    // Start is called before the first frame update
    void Start()
    {
        torrtaRadar = GetComponentInParent<TurretD>();
  
    }

    void OnTriggerEnter(Collider other)
    {
        //el if nos sirve para que pueda reconocer cuando el personajepasa por ahi
        //active el disparo o el mensaje
        //la parte de estado es el cambio de estado busqueda a estado ataque

        if (other.gameObject.tag == "Player")
        {
            torrtaRadar.estadoActual = TurretIA.Ataque;
            StartCoroutine(torrtaRadar.MisilesAtaque());
       
            Debug.Log("Vas a Morrir");
        }
    }
}