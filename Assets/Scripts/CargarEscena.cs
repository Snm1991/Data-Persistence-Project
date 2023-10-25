using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CargarEscena : MonoBehaviour
{

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
    /*public void NombreElegido(string nombreJugador)
    {
        MainManager.Instance.nombre = nombreJugador;
    }*/
}
