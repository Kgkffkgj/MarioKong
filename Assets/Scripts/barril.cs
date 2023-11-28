using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barril : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {

        transform.Translate(0, 1 * Time.deltaTime, 0);
	}

    void OnTriggerEnter2D(Collider2D oi)
    {
        if (oi.tag == "Player")
        {
            Application.LoadLevel("morte");
        }
    }
    
}
