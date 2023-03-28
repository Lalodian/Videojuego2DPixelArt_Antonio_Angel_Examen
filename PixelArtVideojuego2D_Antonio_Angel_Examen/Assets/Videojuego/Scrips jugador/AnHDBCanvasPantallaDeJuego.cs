using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnHDBCanvasPantallaDeJuego : MonoBehaviour
{
    public GameObject[] vidas;
    public void DesactivarVida(int indice)
    {
        vidas[indice].SetActive(false);
    }
    public void ActivarVidas(int indice)
    {
        vidas[indice].SetActive(true);
    }
    
}
