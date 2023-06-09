using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTest : MonoBehaviour
{
    public int vidaPlayer = 100;
    public int atackEnemy = 40;

    void attack()
    {
        int ataque = vidaPlayer - atackEnemy;
        vidaPlayer = ataque;
        Debug.Log("sua vida agora é: " + vidaPlayer);
    }

    private void Start()
    {
        Debug.Log("Sua vida inicial é: " + vidaPlayer);
        attack();
     
    }
}
