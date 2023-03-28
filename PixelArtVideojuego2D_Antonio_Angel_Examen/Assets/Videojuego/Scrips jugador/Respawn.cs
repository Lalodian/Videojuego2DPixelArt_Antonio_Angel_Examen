using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public string Nombredelnivel;

    //Se encarga de Eliminar al personaje si cae o si no los peteoritos 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            SceneManager.LoadScene(Nombredelnivel);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if ( collision.gameObject.tag == "Enemigo")
        {
            Destroy(collision.gameObject);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
