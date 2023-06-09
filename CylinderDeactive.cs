using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderDeactive : MonoBehaviour
{
    public GameObject cilindro;
    void Start()
    {
        if (cilindro.activeSelf)
        {
            cilindro.SetActive(false);
            Debug.Log("Desativou: " + cilindro.activeSelf);
        }
        else
        {
            cilindro.SetActive(true);
            Debug.Log("Ativou: " + cilindro.activeSelf);
        }

        cilindro.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
