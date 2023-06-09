using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactiveBoxCollider : MonoBehaviour
{
    public GameObject DeactivePlayer;

    private void Start()
    {
        DeactivePlayer.SetActive(false);
        DeactivePlayer.GetComponent<BoxCollider>().enabled = false;
    }
}
