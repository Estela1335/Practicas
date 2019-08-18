//Nombre: Melissa Estela Oscoy Parada 
//Profesor: Josue Israel Rivas Diaz
//Materia: Estructura de Datos 
//Titulo: lifeeee

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//pone la vida del player en un objeto de texto
//o un mensaje en especifico
public class Vida : MonoBehaviour
{
    public float vida;
    public Text vidaText;

    private void Start()
    {
        vidaText.text = vida.ToString();
    }

    private void Update()
    {
        vidaText.text = vida.ToString();
    }
}
