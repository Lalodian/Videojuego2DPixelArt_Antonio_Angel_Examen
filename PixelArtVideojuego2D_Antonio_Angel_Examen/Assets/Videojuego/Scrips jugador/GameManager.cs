using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private int vidas = 3;
    public AnHDBCanvasPantallaDeJuego anHDBCanvasPantallaDeJuego;
    public string Nombredelnivel;

    void Awake()
    {
        if(Instance==null)
        {
            Instance = this;
        }else
        {
            Debug.Log("Mas de un GameManager");
        }
    }
    //funciones de vidas
    public void PerderVida()
    {
        vidas -= 1;
        if (vidas == 0)
        {
            SceneManager.LoadScene(Nombredelnivel);
        }
        anHDBCanvasPantallaDeJuego.DesactivarVida(vidas);
    }
    public bool RecuperarVida()
    {
        if (vidas == 3)
        {
            return false;
        }
        anHDBCanvasPantallaDeJuego.ActivarVidas(vidas);
        vidas += 1;
        return true;
    }
}
