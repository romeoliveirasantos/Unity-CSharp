using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour
{
    //classe
    [System.Serializable]// transforma em component
    public class Dinossauro
    {
        //atributos
        public string raca;
        public string tipo;
        public int tamanho;


        //construtor
        public Dinossauro(string Raca, string Tipo, int Tamanho)
        {
            raca = Raca;
            tipo = Tipo;
            tamanho = Tamanho;
        }
    }

    //cria o objeto da classe dinossauro
    public Dinossauro dino;

    private void Start()
    {
        Debug.Log(dino.raca);
    }
}
