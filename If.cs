using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    public int n1;
    public int n2;

   

    void Start()
    {

      
        if (n1 > 0)
        {
            Debug.Log("O número é positivo");
        }
        else if(n1 < 0)
        {
            Debug.Log("O número é negativo");
        }
        else
        {
            Debug.Log("O número é ele mesmo");
        }        
    }


    void Update()
    {
        
    }
}
