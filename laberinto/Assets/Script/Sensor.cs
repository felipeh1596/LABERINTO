using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    public GameObject prueba;
   

    void Start()
    {
        prueba.SetActive(false);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            prueba.SetActive(true);
            
        }
    }

    //private void ontriggerexit(collider other)
    //{
    //    if(other.transform.tag == "player")
    //    {
    //        prueba.setactive(false);
    //    }
    //}


    
}
