using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float speed = 3;
    Vector2 dir = Vector2.right;
    public float upforce = 800;
    public GameObject volta;
         

     void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = dir * speed; 
    }

     void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name != "Mario")
        {
            transform.localScale = new Vector2(-1 * transform.localScale.x, transform.localScale.y);
            dir = new Vector2(-1 * dir.x, dir.y);
        }
        if (coll.gameObject.name == "Mario")
        {
            
        }
    }

     void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Mario")
        {
            if (col.contacts[0].point.y > transform.position.y)
            {
                //o inimigo morre
                GetComponent<Animator>().SetTrigger("died");
                GetComponent<Collider2D>().enabled = false;
                
                Destroy(this.gameObject);
            }
            else
            {
                Application.LoadLevel("morte");
                
            }
           
        }
    }

    
    
}
