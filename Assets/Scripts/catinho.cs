using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catinho : MonoBehaviour
{
    public float velocidade;
    public float x, y, z;
    // Use this for initialization
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = 0;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(velocidade * Time.deltaTime, 0, 0);

        if (transform.position.x >= 9.85)
        {
            transform.position = new Vector3(x, y, z);
        }

    }

      void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Application.LoadLevel("arcanjo");

        }
    }

    //transform.Translate(2 * Time.deltaTime, 0, 0);
}


