using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ejemplo2 : MonoBehaviour
{
    public float velocidad;
    public float tiempodeespera;
    void FixedUpdate()
    {
        transform.Translate(Vector2.right * Time.deltaTime * velocidad);
    }
    private void Update()
    {
        Destroy(this.gameObject, tiempodeespera);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }
}
