using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumScript : MonoBehaviour
{
    public enum direcoes
    {
        Norte,
        Sul,
        Leste,
        Oeste
    }
    public direcoes direcao;

    void Start()
    {
        switch (direcao)
        {
            case direcoes.Norte:
                Debug.Log("Direcão Norte!");
                break;
            case direcoes.Sul:
                Debug.Log("Direcão Sul!");
                break;
            case direcoes.Leste:
                Debug.Log("Direcão Leste!");
                break;
            case direcoes.Oeste:
                Debug.Log("Direcão Oeste!");
                break;
    //default nesse caso não é necessário pois só tem 4 opções.
            //default:
            //    Debug.Log("Sem Direção setada!");
            //    break;

        }
    }

    
    void Update()
    {
        
    }
}
