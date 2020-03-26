using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartScript : MonoBehaviour
{
    //game object fyrir player
    public GameObject Player;
    void OnTriggerEnter(Collider col)
    {
        //ef player snertir hjartað þá fær hann health og destroy-ar hjartað
        if (col.gameObject == Player)
        {
            Destroy(gameObject);
            GameControlScript.health += 1;
            
            
        }
        
    }
}
