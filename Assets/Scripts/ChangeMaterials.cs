using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterials : MonoBehaviour
{

    public Renderer rend;

    public Material color1;
    public Material color2; 
    
    [SerializeField]
    Material color3;

    [SerializeField]
    Material color4; 

    // Start is called before the first frame update
    void Start()
    {        
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.W)){            
            //Debug.Log("Se presiono la tecla W"); //
            rend.material = color1;
        }

        if(Input.GetKeyDown(KeyCode.A)){
            //Debug.Log("Se presiono la tecla A"); //
            rend.material = color2;
        }

        if(Input.GetKeyDown(KeyCode.S)){
            //Debug.Log("Se presiono la tecla S"); //
            rend.material = color3;
        }

        if(Input.GetKeyDown(KeyCode.D)){
            //Debug.Log("Se presiono la tecla D"); //
            rend.material = color4;
        }
    }
}
