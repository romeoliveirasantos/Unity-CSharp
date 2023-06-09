using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    string playerName = "Roxohq";
    [System.Serializable]
    public class NPCs
    {
       public string Name;
       public string Type;
       public int Speed;

        public NPCs(string name, string type, int speed)
        {
            Name = name;
            Type = type;
            Speed = speed;
        }
    }

    public NPCs Mercador;
    public NPCs Bancario;
    public NPCs Alquimista;
    public NPCs Ferreiro;

    [System.Serializable]
    public class NPCphrases
    {
       public string phrase;
        
        public NPCphrases(string frase)
        {
            phrase = frase;
        }
    }

    public List<NPCphrases> npcphrases = new List<NPCphrases>();



    private void Start()
    {
        npcphrases.Add(new NPCphrases("Saudações, " + playerName));
        //Estaticos.estatico.Atack();
        //Debug.Log("Aqui! " + Estaticos.estatico.vida);

        Debug.Log("O dano da sua spell de fogo é: " + Magias.fireAttack.fireSpell);
        Enemyss.Minotaur.MinoMeleeAttack();
        Debug.Log("Passou aqui : "  + Enemyss.Minotaur.MinotaurSpeed);
    }
}
