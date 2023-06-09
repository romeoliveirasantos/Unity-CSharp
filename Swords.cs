using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swords : MonoBehaviour
{

    [System.Serializable]
    public class Espada
    {
        public string SwordName;
        public int SwordDamage;
        public string SwordType;

        //contructor
        public Espada(string n, int d, string t)
        {
            SwordName = n;
            SwordDamage = d;
            SwordType = t;
        }
       
    }

    public List<Espada> espadas = new List<Espada>();
    void Start()
    {
        espadas.Add(new Espada("Mercenary Sword", 100, "Physical"));
        espadas.Add(new Espada("Serpent Sword", 50, "Poison"));
        espadas.Add(new Espada("Giant Sword", 140, "Physical"));
        espadas.Add(new Espada("Fire Sword", 200, "Fire"));
        espadas.Add(new Espada("Glacial Sword", 130, "Ice"));
    }
}
