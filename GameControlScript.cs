using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameControlScript : MonoBehaviour
{
    //geri public gameobject fyrir hjörtun og int fyrir health
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public static int health;
    // Start is called before the first frame update
    void Start()
    {
        //læt health vera 3 of læt hjortun vera active
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        //ef health verdur meira en 3 verður ekki hækkað health
        if(health > 3)
        {
            health = 3;
        }
        // nota case til að birta réttu hjörtu
        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                //Hérna er leikmaður dáinn og ég loada game over scene
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
             
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
        }
    }
}
