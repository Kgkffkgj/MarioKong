using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moeda : MonoBehaviour {

    public GameObject levelManager;



    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.CompareTag("Player"))
            {
            gameObject.GetComponent<AudioSource>().Play();
            levelManager.GetComponent<LevelManeger>().moedas++;
            levelManager.GetComponent<LevelManeger>().pontos += 10;
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
