using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentaBolinha : MonoBehaviour
{
    private Rigidbody rigbody;
    public float velocidade; //publico para podermos customizar

    void Start()
    {
        //adiciona o rigbody da bolinha na nossa variavel
        rigbody = GetComponent<Rigidbody>();
    }

    //Melhora a performance esse evento Fixed.
    void FixedUpdate()
    {
        //Vector3 = x,y,z
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //aplica uma força no rigbody
        rigbody.AddForce(move * velocidade);
    }
}
