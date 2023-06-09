using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttacksMinotauros : MonoBehaviour
{
    public enum TipoAtaque
    {
        FisicoMelee,
        Magico,
        FisicoDistance
    }

    public TipoAtaque MinoTipoAtaque;
    void Start()
    {
        
    }

    
    void Update()
    {
        switch (MinoTipoAtaque)
        {
            case TipoAtaque.FisicoMelee:
                AtaqueFisico();
                break;
            case TipoAtaque.Magico:
                AtaqueMagico();
                break;
            case TipoAtaque.FisicoDistance:
                AtaqueDistance();
                break;
        }
    }

    void AtaqueFisico()
    {
        Debug.Log("Minotauro Ataque Físico");
    }

    void AtaqueMagico()
    {
        Debug.Log("Minotauro Ataque Mágico");
    }

    void AtaqueDistance()
    {
        Debug.Log("Minotauro Ataque Distance");
    }
}
