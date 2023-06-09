using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCase : MonoBehaviour
{
    public int DiaSemana;
    public bool IsHolyday;
    void Start()
    {
        switch (DiaSemana)
        {
            case 1:
                if(IsHolyday == true) {
                Debug.Log("Domingo de Feriado!");
                }
                else { Debug.Log("Domingo!"); }
                break;
            case 2:
                Debug.Log("Segunda-feira");
                break;
            case 3:
                Debug.Log("Terça-feira");
                break;
            case 4:
                Debug.Log("Quarta-feira");
                break;
            case 5:
                Debug.Log("Quinta-feira");
                break;
            case 6:
                Debug.Log("Sexta-feira");
                break;
            case 7:
                Debug.Log("Sábado");
                break;
            default:
                Debug.Log("Fora da data!");
                break;
        }
    }

    
    void Update()
    {
        
    }
}
