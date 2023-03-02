using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoGalactico : MonoBehaviour
{
    private float Xinput;
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void HandleMovement()
    {
        Xinput = Input.GetAxisRaw("Horizontal");
        Vector2 move = new Vector2(x: Xinput * speed,y:rb.velocity.y);
        rb.velocity = move;
        
    }
    private void FixedUpdate()
    {
        HandleMovement();
    }

}
