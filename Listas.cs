using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listas : MonoBehaviour
{
    [System.Serializable]// precisa ter esse serializable para aparecer
  public class Inimigo//classe inimigo
    {
        //atributos dos inimigos
        public string name;
        public int speed;
        public int damage;


        //constructor
        public Inimigo(string n, int s, int d)
        {
            name = n;
            speed = s;
            damage = d;
        }
    }
    
    // criando lista de objeto
    public List<Inimigo> inimigos = new List<Inimigo>();

    private void Start()
    {
        inimigos.Add(new Inimigo("Minotaur", 10, 300));
        inimigos.Add(new Inimigo("Gargole", 13, 200));
        inimigos.Add(new Inimigo("Goblin", 5, 100));
        inimigos.Add(new Inimigo("Dragon", 7, 500));
        inimigos.Add(new Inimigo("Lion", 20, 700));
    }
}
