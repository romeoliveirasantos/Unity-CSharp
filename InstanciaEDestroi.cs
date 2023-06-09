using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaEDestroi : MonoBehaviour
{

    public GameObject bullet;
    public GameObject Gun;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(bullet, Gun.transform.position, Gun.transform.rotation);
            Instantiate(bullet, Gun.transform.position, Gun.transform.rotation);

        }
    }

    
}

    
