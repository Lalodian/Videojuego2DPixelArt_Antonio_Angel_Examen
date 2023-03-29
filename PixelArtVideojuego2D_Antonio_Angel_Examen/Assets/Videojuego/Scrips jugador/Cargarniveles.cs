using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Cargarniveles : MonoBehaviour
{
    public string Nombredelnivel;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player") ;
        {
            SceneManager.LoadScene(Nombredelnivel);
        }
    }
}
