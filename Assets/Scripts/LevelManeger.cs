using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManeger : MonoBehaviour {

    public int moedas;
    public int pontos;
    
    

    public Text moedasT;
    public Text pontosT;
   
     
    void Update()
    {

        moedasT.text = moedas.ToString();
        pontosT.text = pontos.ToString();
      

    }
}
