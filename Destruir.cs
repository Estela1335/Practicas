using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    public GameObject[] tanqueEnemigo;
    public GameObject[] almacenTanque;
    public GameObject explosionTanque;
    // Start is called before the first frame update
    void Start()
    {
        tanqueEnemigo = GameObject.FindGameObjectsWithTag("tanqueEnemigo");
        almacenTanque = new GameObject[tanqueEnemigo.Length];
        for (int i = 0; i < tanqueEnemigo.Length; i++)
        {
            almacenTanque[i] = tanqueEnemigo[i];
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < almacenTanque.Length; i++)
            {
                Instantiate(explosionTanque, almacenTanque[i].transform.position,almacenTanque[1].transform.rotation);
                Destroy(almacenTanque[i]);
            }
        
            /**/
        }
    }
}
