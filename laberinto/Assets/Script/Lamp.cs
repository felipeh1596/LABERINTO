using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour, IInteractable
{
    [SerializeField]
    Light light;


    public void Awake()
    {
        light.enabled = false;
    }

    public void Interact()
    {
        light.enabled = true;
    }   
}
