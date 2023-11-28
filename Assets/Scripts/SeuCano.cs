using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeuCano : MonoBehaviour {

    public Transform destino;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            col.transform.position = destino.position;
        }
    }
}
