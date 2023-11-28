using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donk : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D oi)
    {
        if (oi.tag == "Player")
        {
            Destroy(this.gameObject); 
        }
       
    }
}
