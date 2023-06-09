using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEach : MonoBehaviour
{

    public string[] Names;
    // Start is called before the first frame update
    void Start()
    {
        foreach ( string n in Names)
        {
            if(n == "Rome")
            {
                Debug.Log("Olá" + n + " , você é especial!");
            }else if (n == "Vic")
            {
                Debug.Log("Olá, " + n + " te achei seu viado!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
