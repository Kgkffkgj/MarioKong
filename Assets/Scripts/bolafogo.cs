using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent (typeof(Rigidbody2D))]


public class bolafogo : MonoBehaviour

{

    [SerializeField]
    private float velocidade;
    

    
    public GameObject explosao;

    private Vector2 direcao;
    private float tempo = 0.08f;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    public void Inicializar(Vector2 girou)
    {
        direcao = girou;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        rb.velocity = direcao * velocidade;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="inimigo")
        {
            explosao.SetActive(true);
            StartCoroutine("Destruir");
        }
    }

    IEnumerator Destruir()
    {
        yield return new WaitForSeconds(tempo);
            Destroy(gameObject);
    }
}
