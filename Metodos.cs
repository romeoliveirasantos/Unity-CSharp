using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{

    public int Vida;
    public int ValorDano;
    public int SpellHeal;
    public bool IsLive = true;
    public int VidaAtual;
    public int EnemyRange;
    
    void Start()
    {
        DiminuirVida(ValorDano);
        Heal();
        VidaAtual = Vida;
        if(Vida == 0) {
            IsLive = false;
            Debug.Log("Você morreu!" + " Vida Atual: " + VidaAtual);
        }
        else
        {
            Debug.Log("Sua vida atual é: " + VidaAtual);
        }
        MagiaCurar();

    }

    
    void Update()
    {
        atackPlayer();
    }

    void DiminuirVida(int Dano)
    {
        Vida -= Dano;
    }

    void Heal()
    {
        if (IsLive == true)
        {
            Vida += SpellHeal;
            Debug.Log("Você foi curado em :" + SpellHeal);
        }
        
    }
    void MagiaCurar()
    {
        switch (SpellHeal)
        {
            case 1:
                if(IsLive == true) { 
                Debug.Log("Low Heal");
                }
                break;
            case 2:
                if (IsLive == true)
                {
                    Debug.Log("Med Heal");
                }
                break;
            case 3:
                if (IsLive == true)
                {
                    Debug.Log("Big Heal");
                }
                break;
        }
    }
    void atackPlayer()
    {
        if(EnemyRange == 0)
        {
            if(IsLive == true) { 
            Debug.Log("Você tomou um ataque!");
            }
        }
    }
}

