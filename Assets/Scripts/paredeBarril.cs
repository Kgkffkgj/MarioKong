using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paredeBarril : MonoBehaviour {

    public GameObject suamae;

    void OnTriggerEnter2D(Collider2D chineis)
    {
        if (chineis.tag == "barril")
        {
            suamae.transform.position = new Vector3(36.704f, -0.549f, 0);
        }
    }
}
