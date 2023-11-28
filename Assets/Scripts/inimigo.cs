using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame



  

    
 


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Mario")
        {
            if (col.contacts[0].point.y > transform.position.y)
            {
                //o inimigo morre
                
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

