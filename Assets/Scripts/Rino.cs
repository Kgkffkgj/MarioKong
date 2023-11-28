using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rino : MonoBehaviour
{

    public GameObject levelManager;


    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.CompareTag("Player"))
        {
            gameObject.GetComponent<AudioSource>().Play();
            levelManager.GetComponent<LevelManeger>().moedas += 7;
            levelManager.GetComponent<LevelManeger>().pontos += 75;
        }
    }

    void OnTriggerExit2D(Collider2D obj)
    {
        if (obj.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
