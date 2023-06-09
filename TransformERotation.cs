using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformERotation : MonoBehaviour
{

    public float velocidade;
    public float rotacao;
   
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //podemos usar o new vector 3 e passar a direção manual
            //o vector3.foward é a direção 0,0,1 < eixo Z
            transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * velocidade * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector2.down * rotacao * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector2.up  * rotacao * Time.deltaTime);
        }
         if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * velocidade * Time.deltaTime);
        }

        

        

    }
}
