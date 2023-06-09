using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyss : MonoBehaviour
{
    public int MinotaurMeleeAttack = 100;
    public int MinotaurSpeed = 5;
    public bool MinotaurIsLive = true;
    public int Range = 0;

    public static Enemyss Minotaur;

    private void Start()
    {
        Minotaur = this;
        MinoMeleeAttack();
    }
    
    public void MinoMeleeAttack()
    {
        if(MinotaurIsLive == true && Range == 0)
        {
            Debug.Log("Minotaur Attacked Melee: " + MinotaurMeleeAttack);
        }
    }

}
