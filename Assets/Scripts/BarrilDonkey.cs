using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrilDonkey : MonoBehaviour {

    public GameObject suamae;
    public GameObject suamae2;
    public float x, y, z;
    

    void OnTriggerEnter2D(Collider2D chineis)
    {
        if (chineis.tag == "barril")
        {
            suamae.transform.position = new Vector3(x,y,z);
        }

        if (chineis.tag == "barril2")
        {
            suamae2.transform.position = new Vector3(x, y, z);
        }
       
    }
}
