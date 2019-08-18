using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform myTransform;
    
    void Start()
    {
        myTransform = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            myTransform.Translate( 0, 0, 50f * Time.deltaTime);


        }
        if (Input.GetKey(KeyCode.S))
        {
            myTransform.Translate(0, 0, -50f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            myTransform.Rotate(0, 50f*Time.deltaTime,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            myTransform.Rotate(0, -50f * Time.deltaTime, 0);

        }
    }
}