using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{

    void Start()
    {
        AudioSystem2D.Instance.PlayMusic(songName:"Ambiente");
    }

    
    void Update()
    {
        
    }
}
