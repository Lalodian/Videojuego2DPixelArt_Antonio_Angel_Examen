using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class AnMeteoritosAtaque : MonoBehaviour
{
    //Variables Para el eje X
    [SerializeField] private float minimoX;
    [SerializeField] private float maximoX;
    //El prefap para dañar a mi monito
    public GameObject prefapMeteoro1;
    public GameObject prefapMeteoro2;
    //Cuanto tiempo tardara en Respawnear la siente esfera
    public float tiempoDeRespawn;
    //Lo mismo pero para programar
    private float tiempo;


    void Start()
    {
        tiempo = tiempoDeRespawn;
    }
    void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= tiempoDeRespawn)
        {
            tiempo = 0f;

            float objetoRandomX1 = Random.Range(minimoX, maximoX);
            float objetoRandomX2 = Random.Range(minimoX, maximoX);
            //poder manipular el Prefap 
            GameObject prefapObjetoM1 = Instantiate(prefapMeteoro1, new Vector2(objetoRandomX1, 16), Quaternion.identity);
            Debug.Log("Meteoro1");
            GameObject prefapObjetoM2 = Instantiate(prefapMeteoro2, new Vector2(objetoRandomX2, 16), Quaternion.identity);
            Debug.Log("Meteoro2");
        }

    }
}
