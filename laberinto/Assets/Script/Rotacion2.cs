using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion2 : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {
        transform.Rotate(new Vector3(0f, 80f, 0f) * Time.deltaTime);
        RotarEnemigo();

    }

    public void RotarEnemigo()
    {
        Vector3 desplazamientoHeroe = GameObject.Find("_Heroe").transform.position - transform.position;
        float distanciaAHeroe = desplazamientoHeroe.magnitude;
        float prodPunto = Vector3.Dot(transform.forward, desplazamientoHeroe.normalized);

        if(distanciaAHeroe < 14f && prodPunto > 0.5f)
        {
            Quaternion avistarHeroe = Quaternion.LookRotation(desplazamientoHeroe.normalized);
            transform.rotation = Quaternion.Slerp(transform.rotation, avistarHeroe, 1f);
        }
    }
}
