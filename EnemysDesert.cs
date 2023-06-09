using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysDesert : MonoBehaviour
{
    [System.Serializable]
    //Classe Centipede
    public class Centipede
    {
        //Atributos
        public string Name;
        public string Element;
        public int Damage;
        public float Velocity;
        public int Experience;


        //constructor
        public Centipede(string name, string element, int damage, float vel, int experience)
        {
            Name = name;
            Element = element;
            Damage = damage;
            Velocity = vel;
            Experience = experience;
        }
    }

    [System.Serializable]
    public class Minotaur
    {
        public string Name;
        public string Element;
        public int Damage;
        public float Velocity;
        public int Experience;

        public Minotaur(string name, string element, int damage, float vel, int experience)
        {
            Name = name;
            Element = element;
            Damage = damage;
            Velocity = vel;
            Experience = experience;
        }
    }



    //objetos das classes
    public Centipede Centopeia;
    public Minotaur MinotauroGuard;
    public Minotaur MinotauroMage;





    private void Start()
    {
        //Centopeia
        Debug.Log("Name: " + Centopeia.Name);
        Debug.Log("Element: " + Centopeia.Element);
        Debug.Log("Damage: " + Centopeia.Damage);
        Debug.Log("Speed: " + Centopeia.Velocity);
        Debug.Log("EXP: " + Centopeia.Experience);

        //Minitauro Guard
        Debug.Log("Name: " + MinotauroGuard.Name);
        Debug.Log("Element: " + MinotauroGuard.Element);
        Debug.Log("Damage: " + MinotauroGuard.Damage);
        Debug.Log("Speed: " + MinotauroGuard.Velocity);
        Debug.Log("EXP: " + MinotauroGuard.Experience);

        //Minotauro Mage
        Debug.Log("Name: " + MinotauroMage.Name);
        Debug.Log("Element: " + MinotauroMage.Element);
        Debug.Log("Damage: " + MinotauroMage.Damage);
        Debug.Log("Speed: " + MinotauroMage.Velocity);
        Debug.Log("EXP: " + MinotauroMage.Experience);
    }


}
