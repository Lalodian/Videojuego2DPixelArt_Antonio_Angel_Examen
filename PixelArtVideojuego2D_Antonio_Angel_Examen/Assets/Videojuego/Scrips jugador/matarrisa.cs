using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matarrisa : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "player") 
        {
            Destroy(collision2D.gameObject);
        }
    }
    
}
