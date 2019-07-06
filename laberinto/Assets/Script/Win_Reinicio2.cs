using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win_Reinicio2 : MonoBehaviour
{
    float contador = 2;
    public Transform playerTransform;
    public GameObject punto;

    public bool ReinicioAlGanar()
    {
        Vector3 desplazamientoDePuntoAPlayer = punto.transform.position - playerTransform.position;
        float distanciaAPlayer = desplazamientoDePuntoAPlayer.magnitude;

        if (distanciaAPlayer < 2)
        {
            contador -= Time.deltaTime;

            if (contador <= 0)
            {
                RestartGame();

                return true;
            }
        }
        return false;
    }

    void Update()
    {
        ReinicioAlGanar();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Inicio");
    }
}
