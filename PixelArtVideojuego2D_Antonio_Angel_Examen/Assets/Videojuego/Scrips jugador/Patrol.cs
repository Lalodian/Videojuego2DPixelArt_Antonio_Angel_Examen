using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public GameObject plataforma;
    public float vel;
    public Transform puntoActual;
    public Transform[] points;
    public int seleccionDePuntos;
    // Start is called before the first frame update
    void Start()
    {
        puntoActual = points[seleccionDePuntos];
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        plataforma.transform.position = Vector3.MoveTowards(
            plataforma.transform.position, puntoActual.position,
            Time.deltaTime * vel);
        if(plataforma.transform.position==puntoActual.position)
        {
            seleccionDePuntos += 1;
            if(seleccionDePuntos== points.Length)
            {
                seleccionDePuntos = 0;
            }
            puntoActual = points[seleccionDePuntos];
        }
    }
}
