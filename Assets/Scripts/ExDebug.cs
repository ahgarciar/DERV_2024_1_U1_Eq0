using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExDebug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            Debug.Log("Se presiono la tecla W"); //
        }

        if(Input.GetKey(KeyCode.A)){
            Debug.Log("Se presiono la tecla A"); //
        }

        if(Input.GetKey(KeyCode.S)){
            Debug.Log("Se presiono la tecla S"); //
        }

        if(Input.GetKey(KeyCode.D)){
            Debug.Log("Se presiono la tecla D"); //
        }

    }
}
