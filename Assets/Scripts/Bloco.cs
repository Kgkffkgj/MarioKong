using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour {

    public Animator anim;
    public AudioSource audio;
    public LevelManeger levelManager;
    public GameObject bloco;
    

    void Start()
    {
        levelManager = GameObject.Find("LevelManeger").GetComponent<LevelManeger>();
        anim = gameObject.GetComponentInParent<Animator>();
        audio = gameObject.GetComponentInParent<AudioSource>();
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            anim.SetBool("Bateu", false);
            
        }
    }

    private void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            
            if (anim.GetBool("Bateu") == false) 
            {

                anim.SetBool("Bateu", true);
                audio.Play();
                //bloco.transform.position = new Vector2(bloco.transform.position.x, bloco.transform.position.y * -0.8f);
                levelManager.pontos += 100; 
                levelManager.moedas += 1;
            }
           
        }
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            bloco.transform.position = new Vector2(bloco.transform.position.x, bloco.transform.position.y * 3.5f);

        }
    }

    void OnTriggerExit2D(Collider2D obj)
    {
        if (obj.CompareTag("Player"))
        {
            Destroy(bloco);
        }
    }
}
