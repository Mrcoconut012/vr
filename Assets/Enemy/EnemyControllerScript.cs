using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyControllerScript : MonoBehaviour
{
    private GameObject player;
     private NavMeshAgent agent;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
       agent.SetDestination(player.transform.position); 
    }
}
