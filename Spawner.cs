using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float SpawnerTempo = 5f;

    public List<GameObject> Paredes = new List<GameObject>();
    float TempoCont;

    void Start()
    {
        //TempoCont = 0f;
    }
   

    
    void Update()
    {
        TempoCont += Time.deltaTime;

        if(TempoCont >= SpawnerTempo)
        {
            if( Paredes.Count > 0) { 
            Instantiate(Paredes[Random.Range(0,Paredes.Count)], transform.position, transform.rotation);
            TempoCont = 0f;
            }
        }
        else
        {
            Debug.Log("A lista 'paredes' está vazia.Certifique - se de atribuir objetos à lista no editor da Unity.");
        }
        Debug.Log(Paredes.Count);
    }
    
}
