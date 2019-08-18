using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum TurretIA
{
    Buscando,
    Ataque
}

public class TurretD : MonoBehaviour
{
    public Rigidbody bullet;
    public Transform[] Cañon;
    public float fuerzaDisparo;
    public TurretIA estadoActual = new TurretIA();
    int ContadorMisiles;
    public int aumento = 0;


    private void Start()
    {
        ContadorMisiles = 0;

       estadoActual = TurretIA.Buscando;

       //StartCoroutine(MisilesAtaque());
    }

    // Update is called once per frame
   // void Update()
    //{
        //if (estadoActual==TurretIA.Ataque)
        //{

           // for (int i = 0; i < 3; i++)
            //{
              //  Rigidbody bulletPos = Instantiate(bullet, Cañon[i].position, Cañon[i].rotation) as Rigidbody;

                //bulletPos.AddForce(Cañon[i].forward * fuerzaDisparo);
                //ContadorMisiles = i + 1;

                //if (ContadorMisiles >= 3 && i >=Cañon.Length-1)
                //{
                   // ContadorMisiles = 3;
                    //estadoActual = TurretIA.Buscando;
                //}
            //}
            
        //}
    //}
    //fin update
    public IEnumerator MisilesAtaque()
    {
        if (estadoActual == TurretIA.Ataque)
        {
            Rigidbody bulletPos = Instantiate(bullet, Cañon[aumento].position, Cañon[aumento].rotation) as Rigidbody;
            bulletPos.AddForce(Cañon[aumento].forward * fuerzaDisparo);
            ContadorMisiles++;
            yield return new WaitForSeconds(3);
            aumento++;
            if (aumento == 6
                && aumento > Cañon.Length - 1)
            {
                aumento = 0;
            }
            if (ContadorMisiles != 9)
            {
                StartCoroutine(MisilesAtaque());
            }
            else if (ContadorMisiles == 9)
            {
                estadoActual = TurretIA.Buscando;
            }
            yield return null;

        }











    }


}


