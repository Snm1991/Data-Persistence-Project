using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public string nombreJugador;
    public InputField mainInputField;
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void LockInput(InputField input)
    {
        mainInputField.onEndEdit.AddListener(delegate { LockInput(mainInputField); });
        nombreJugador = mainInputField.text;
    }
}

