using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    //nota tranform á player og respawn point
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    void OnTriggerEnter(Collider other)
    {
        //ef player fer í vatnið þá spawnar hann á respawn point og tekur í burtu einn health
        player.transform.position = respawnPoint.transform.position;
        GameControlScript.health -= 1;
    }
}
