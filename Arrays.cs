using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    
    
    public GameObject[] Player;

    public int[] valores;


    
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectsWithTag("Player");

        //foreach (GameObject p in Player) {

        //    Debug.Log(p.name);

        //}
        for (int i = 0; i < Player.Length; i++)
        {
            Debug.Log(Player[i].name);

        }
        //for(int i = 0; i < valores.Length; i++)
        //{

        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
