using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public Animator player;

    public float speed;

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position +=transform.forward * speed;
            player.SetBool("Correr", true);
        }
        else
        {
            player.SetBool("Correr", false);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position -=transform.forward * speed;
            player.SetBool("CaminarAtras", true);
        }
        else
        {
            player.SetBool("CaminarAtras", false);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position -=transform.right * speed;
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponentInParent<IInteractable>() != null)
        {
            other.GetComponentInParent<IInteractable>().Interact();
        }
    }   
}

