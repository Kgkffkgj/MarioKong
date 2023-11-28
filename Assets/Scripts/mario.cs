using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mario : MonoBehaviour
{
        
    public float velocidade;
    public float ForcaDoPulo;
    public bool noChao = true;
    public bool girou = false;
    public AudioSource pulo;
    public AudioSource pulogirando;
    public Animator anim;
    public Rigidbody2D rb2d;
    public float velomax;
    public bool correndo;

    public Transform Mario;

    public GameObject BalaPrefab;
    public Transform ShotSpawner;

    public float fireRate = 0.5f;
    public float nextFire;


    
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        anim.SetBool("NoChao", noChao);
        anim.SetBool("Correndo", correndo);
      
        anim.SetFloat("Velocidade", Mathf.Abs(rb2d.velocity.x));

        //ele vai andar para direita
        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            
            transform.localScale = new Vector3(-1, 1, 1);
            if ((rb2d.velocity.magnitude < velomax) && (!anim.GetBool("Abaixado")) && (!anim.GetBool("parado")))
          
            rb2d.AddForce(Vector2.right * velocidade);
        }

        //ele vai andar para a esquerda
        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            transform.localScale = new Vector3(1, 1, 1);
            if ((rb2d.velocity.magnitude < velomax) && (!anim.GetBool("Abaixado")) && (!anim.GetBool("parado")))
                rb2d.AddForce(Vector2.left * velocidade);
        }

        //pular
        if (Input.GetButtonDown("Jump"))
        {
            if (noChao) {
                rb2d.AddForce(Vector2.up * ForcaDoPulo);
                pulo.Play();
            }
        }

        //abaixar
        if (noChao)
        {
            if (Input.GetButton("Abaixar"))
            {

                anim.SetBool("Abaixado", true);
                BoxCollider2D box = gameObject.GetComponent<BoxCollider2D>();
                box.size = new Vector2(box.size.x, 0.1096337f);
                box.offset = new Vector2(box.offset.x, -0.02671149f);
                
            }
            else
            {
                anim.SetBool("Abaixado", false);
                BoxCollider2D box = gameObject.GetComponent<BoxCollider2D>();
                box.size = new Vector2(box.size.x, 0.1430836f);
                box.offset = new Vector2(box.offset.x, -0.009986544f);
            }
        }
        //girar
        if (Input.GetButtonDown("Girar"))
        {
            if (noChao)
            {
                rb2d.AddForce(Vector2.up * ForcaDoPulo);
                pulogirando.Play();
                girou = true;
               
            }
        }

        //correr
        if (Input.GetButton("Correr"))
        {
            if (noChao)
            {
                velocidade = 6.5f;
                velomax = 3;
                correndo = true;

            }
        }
            else
            { 
                if ((noChao) && (Mathf.Abs(rb2d.velocity.x) >= 0.5f) && (correndo))
                {
                    anim.SetBool("parado", true);
                    
                }
                else
                {
                    if ((noChao) && (Mathf.Abs(rb2d.velocity.x) < 0.3f) && (correndo))
                    {
                        anim.SetBool("parado", false);
                        correndo = false;

                    }
                velocidade = 5;
                velomax = 2;
                }
            }

       

        //morrer
        if (transform.position.y <= -8.91f)
        {
           
            Application.LoadLevel("morte");
        }
        


        //atirar

        if (Input.GetKeyDown(KeyCode.B) && Time.time > nextFire)
        {
            anim.SetBool("bolinhafogo", true);
            nextFire = Time.time + fireRate;
            GameObject tempBullet = Object.Instantiate(BalaPrefab, ShotSpawner.position, ShotSpawner.rotation);
            
            if (Mario.transform.localScale.x > 0)
            {
                tempBullet.transform.eulerAngles = new Vector3(0, 0, 180);

            }



        }



        }

   

  
}



