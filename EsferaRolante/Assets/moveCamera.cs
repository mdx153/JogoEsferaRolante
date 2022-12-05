using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public GameObject objetoBolinha; //vamos passar o objeto da sphere
    private Vector3 posicaoInicial; //vai guardar a posi��o inicial x,y,z da bolinha

    void Start()
    {
        //a subtra��o � feita para encontrar a diferen�a entre as posi��es da camera e da esfera, encontrando assim a "distancia" entre eles.
        posicaoInicial = transform.position - objetoBolinha.transform.position;
    }

    //late por que atualiza a posi��o da bolinha e depois da camera
    void LateUpdate()
    {
        //Esta opera��o permite que esta distancia seja calculada e mantida de forma relativa ao inv�s de absoluta. 
        //(posi��o atual da esfera) + (distancia inicial da c�mera para esfera) 
        transform.position = objetoBolinha.transform.position + posicaoInicial;
    }
}
