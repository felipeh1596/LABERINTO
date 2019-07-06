using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rayo2 : MonoBehaviour
{
    public Transform playerTransform;
    Transform enemyTransform;
    public GameObject warning;
    float contador;

    [SerializeField]
    float rangeOfSight = 14f;

    private void Awake()
    {
        enemyTransform = transform;
    }



    void Update()
    {
        bool isPlayerOnSight = SightPlayer();
        warning.SetActive(isPlayerOnSight);
        if(isPlayerOnSight == true)
        {
            contador += Time.deltaTime;
            if(contador > 2f)
            {
                SceneManager.LoadScene(0);
            }

        }
        else
        {
            contador = 0;
        }
    }

    private bool SightPlayer()
    {
        Vector3 displacementToPlayer = playerTransform.position - enemyTransform.position;
        float distanceToPlayer = displacementToPlayer.magnitude;

        if (distanceToPlayer < rangeOfSight)
        {
            float dotProduct = Vector3.Dot(enemyTransform.forward, displacementToPlayer.normalized);
            if (dotProduct >= 0.5f)
            {
                RaycastHit hit;
                if (Physics.Raycast(enemyTransform.position + displacementToPlayer.normalized * 1.01f, displacementToPlayer.normalized, out hit, Mathf.Infinity))
                {
                    Debug.DrawRay(enemyTransform.position + displacementToPlayer.normalized * 1.01f, displacementToPlayer.normalized * hit.distance, Color.blue);
                    if (hit.collider.gameObject.name == "_Heroe")
                        return true;
                }
            }
        }
        return false;
    }
}
