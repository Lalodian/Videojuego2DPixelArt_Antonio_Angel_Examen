using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejemplo3 : MonoBehaviour
{
    public GameObject prefab;
    public float intervalo = 5;
    private float tiempo;
    public float intrvaloParaCrear = 5;
    public Vector2 nuevaPos;
    
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        if(tiempo>=intervalo)
        {
            GameObject nuevoObjeto = Instantiate(prefab);
            Vector2 posFinal = nuevaPos;
            posFinal = (Vector2)transform.position + nuevaPos;
            nuevoObjeto.transform.position = posFinal;
            tiempo -= intervalo;
        }
                
           
        
    }
}
