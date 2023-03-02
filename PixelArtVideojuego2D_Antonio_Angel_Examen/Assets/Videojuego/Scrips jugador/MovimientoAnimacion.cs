using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAnimacion : MonoBehaviour
{
    // caminata
    private Rigidbody2D rb;
    private Animator Animator;
    

    // cargar variables para saltar
    public float fuerzaSalto = 500f;
    public LayerMask capaDelPiso;
    public Transform revisarPiso;
    private float radio = 0.07f;
    private bool EstaenelPiso = true;
    //cargar variable para la caminata
    private float speed = 2.5f;
    private bool EsCaminando;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //carga el rigid body del objeto que tiene este codigo   
        Animator = GetComponent<Animator>();//carga el animator del objeto que tiene el script
    }
    private void FixedUpdate()
    {
        EstaenelPiso = Physics2D.OverlapCircle(revisarPiso.position, radio, capaDelPiso);
        Animator.SetBool( "Salto",!EstaenelPiso);
    }
    void Update()
    {
        //Mover a la derecha :3
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            /*Animator.SetBool("Escaminando", true);
            rb.AddForce(Vector2.forward* speed, ForceMode2D.Force);

            /*Xinput = Input.GetAxisRaw("Horizontal");
            Vector2 move = new Vector2(x: Xinput * speed, y: rb.velocity.y);
            rb.velocity = move;*/
            Animator.SetBool("Escaminando", true);
            EsCaminando = true;
            transform.localRotation = Quaternion.Euler(0,0,0);
            speed = 2.5f;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Animator.SetBool("Escaminando", false);
            EsCaminando = false;
        }
        //Mover a la izquierda :3
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Animator.SetBool("Escaminando", true);
            EsCaminando = true;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            speed = -2.5f;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Animator.SetBool("Escaminando", false);
            EsCaminando = false;
        }
        //codigo para salto :3
        if (EstaenelPiso)
        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.AddForce(new Vector2(0, fuerzaSalto));
            }
        }
        //aplicar fuerza de caminar :3
        if (EsCaminando)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }


    } 
   
}
