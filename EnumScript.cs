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
                Debug.Log("Direc�o Norte!");
                break;
            case direcoes.Sul:
                Debug.Log("Direc�o Sul!");
                break;
            case direcoes.Leste:
                Debug.Log("Direc�o Leste!");
                break;
            case direcoes.Oeste:
                Debug.Log("Direc�o Oeste!");
                break;
    //default nesse caso n�o � necess�rio pois s� tem 4 op��es.
            //default:
            //    Debug.Log("Sem Dire��o setada!");
            //    break;

        }
    }

    
    void Update()
    {
        
    }
}
