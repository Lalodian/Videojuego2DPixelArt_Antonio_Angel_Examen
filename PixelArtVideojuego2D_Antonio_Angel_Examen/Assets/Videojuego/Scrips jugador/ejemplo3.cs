using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejemplo3 : MonoBehaviour
{
    public GameObject prefab;
    public float intervalo = 5;
    private float tiempo;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        if(tiempo>=intervalo)
                {
            Instantiate(prefab);
            tiempo -= intervalo;
        }
    }
}
