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
            Debug.Log("O n�mero � positivo");
        }
        else if(n1 < 0)
        {
            Debug.Log("O n�mero � negativo");
        }
        else
        {
            Debug.Log("O n�mero � ele mesmo");
        }        
    }


    void Update()
    {
        
    }
}
