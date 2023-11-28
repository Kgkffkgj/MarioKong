using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bebe : MonoBehaviour {

	// Use this for initialization
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Application.LoadLevel("morte");

        }

    }
}
