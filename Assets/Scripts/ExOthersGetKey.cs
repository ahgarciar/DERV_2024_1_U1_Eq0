using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExOthersGetKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
            Debug.Log("Se presiono la tecla W"); //
        }

        if(Input.GetKeyDown(KeyCode.A)){
            Debug.Log("Se presiono la tecla A"); //
        }

        if(Input.GetKeyUp(KeyCode.S)){
            Debug.Log("Se presiono la tecla S"); //
        }

        if(Input.GetKeyUp(KeyCode.D)){
            Debug.Log("Se presiono la tecla D"); //
        }

    }
}
