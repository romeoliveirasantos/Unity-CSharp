using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MoveSpeed;
    public int PlayerLife;


    void Start()
    {
        
    }

    
    void Update()
    {
        if (PlayerLife >= 1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector2.up * MoveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector2.down * MoveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);
            }

        }
    }
}
