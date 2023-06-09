using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estaticos : MonoBehaviour
{


    //metodos e variaveis estaticos

    //declarando metodo estatico
    public static Estaticos estatico;

    //declarando variaveis estaticas
    public int vida = 10;
    public int damage = 5;
    
    void Start()
    {
        //declarando que o metodo estatico recebe ele
        //e agora pode ser chamado de qualquer script
        estatico = this;
        FireDamage();
        if(vida <= 0)
        {
            Debug.Log("Você morreu!");
        }
        
    }


     //criando um metodo
    public void Atack()
    {
        int vidaAtual = vida - damage;
        Debug.Log("Vida: " + vida);
        Debug.Log("Você recebeu: " + damage + " de dano! " + "Agora sua vida é: " + vidaAtual);
    }

   
    public void FireDamage()
    {
        int playerAttack = vida - Magias.fireAttack.fireSpell;
        vida = playerAttack;
        Debug.Log("Após o ataque de fogo sua vida é: " + vida);
    }
}
