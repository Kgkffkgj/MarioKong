using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaoCheck : MonoBehaviour {

    public GameObject Mario;

    void OnCollisionEnter2D(Collision2D obj)
    {
            Mario.GetComponent<mario>().noChao = true;
        if (Mario.GetComponent<mario>().girou == true)
        {
            Mario.GetComponent<Animator>().SetBool("Girando", false);
            Mario.GetComponent<mario>().girou = false;
        }
    }

    void OnCollisionStay2D(Collision2D obj)
    {
        Mario.GetComponent<mario>().noChao = true;
    }

    void OnCollisionExit2D(Collision2D obj)
    {
        Mario.GetComponent<mario>().noChao = false;
        if (Mario.GetComponent<mario>().girou == true)
        {
            Mario.GetComponent<Animator>().SetBool("Girando", true);
        }
    }
}
