using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara1 : MonoBehaviour
{
    public GameObject _Heroe;
    private Vector3 distancia;
    void Start()
    {
        distancia = transform.position - _Heroe.transform.position;
    }

    
    void Update()
    {
        transform.position = _Heroe.transform.position + distancia;
    }
}
