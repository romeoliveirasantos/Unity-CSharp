using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magias : MonoBehaviour
{
    public int fireSpell = 40;

    public static Magias fireAttack;

    private void Start()
    {
        fireAttack = this;
    }

}
