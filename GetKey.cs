using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{

    int NumeroVezes = 0;

    void OnMouseDown()
    {
        Debug.Log("Cliclou!");
    }

    void OnMouseDrag()
    {
        Debug.Log("Clicou e arrastou!");
    }
    private void OnMouseEnter()
    {
        Debug.Log("Mouse Entrou!");
    }

    private void OnMouseExit()
    {
        Debug.Log("Mouse Saiu! ");
    }

    private void OnMouseOver()
    {
        Debug.Log("Est� chamando a todo frame");
    }
    private void OnMouseUp()
    {
        Debug.Log("Soltou o bot�o do mouse!");
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("Bot�o foi liberado no mesmo objeto que foi pressionado!");
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            int contagem = NumeroVezes + 1;
            Debug.Log("Voc� apertou o espa�o: " + contagem);
            NumeroVezes++;
        }
    }
}
