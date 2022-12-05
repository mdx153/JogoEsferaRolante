using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public GameObject objetoBolinha; //vamos passar o objeto da sphere
    private Vector3 posicaoInicial; //vai guardar a posição inicial x,y,z da bolinha

    void Start()
    {
        //a subtração é feita para encontrar a diferença entre as posições da camera e da esfera, encontrando assim a "distancia" entre eles.
        posicaoInicial = transform.position - objetoBolinha.transform.position;
    }

    //late por que atualiza a posição da bolinha e depois da camera
    void LateUpdate()
    {
        //Esta operação permite que esta distancia seja calculada e mantida de forma relativa ao invés de absoluta. 
        //(posição atual da esfera) + (distancia inicial da câmera para esfera) 
        transform.position = objetoBolinha.transform.position + posicaoInicial;
    }
}
