using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{

    public string NamePlayer;
    public int forca;
    public float velocidade = 10.10f;
    public bool isLive;
    public string vocation;
    public GameObject Gameobject;

    // Start is called before the first frame update
    void Start()
    {
        if (forca == 10 && velocidade == 30 && isLive == true)
        {
            if(vocation == "Druid") { 
            Debug.Log("O player está vivo e seu nome é: " + NamePlayer);
                Debug.Log(velocidade);
            }
        }

        Gameobject = gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
  
}
