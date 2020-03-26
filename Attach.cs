using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attach : MonoBehaviour
{
    //game objec fyrir player
    public GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        //lætur player geta verið á platform
        if(other.gameObject == Player)
        {
            Player.transform.parent = transform;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //player fer af platform
        if (other.gameObject == Player)
        {
            Player.transform.parent = null;
        }
    }

}
