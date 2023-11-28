using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agua : MonoBehaviour {
    public GameObject volta;
	// Use this for initialization
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Application.LoadLevel("morte");

        }
    }
}
