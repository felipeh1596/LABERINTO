using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy1 : MonoBehaviour
{
    public List<Transform> punto;
    public int actualTarget = 0;


    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        foreach(Transform entero in punto)
        {
            agent.destination = punto[actualTarget].position;
            actualTarget++; 
        }
        
    }


    void Update()
    {
        
    }
}
