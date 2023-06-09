using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativaLuz : MonoBehaviour
{

    public GameObject luz;
    // Start is called before the first frame update
    void Start()
    {

        luz.GetComponent<Light>().enabled = false;


        //activeself usado para lógicas onde pode ser ativado via script
        if (luz.activeSelf)
        {
            luz.GetComponent<Light>().enabled = true;
        }
        else
        {
            luz.GetComponent<Light>().enabled = false;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
}
