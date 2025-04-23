using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaveManager : MonoBehaviour
{
    public TMP_InputField inputClave;
    public TextMeshProUGUI txtMensaje;

    string clave = "tic2025";
    // Start is called before the first frame update
    void Start()
    {
        txtMensaje.text = "";

    }
    
    // siempre se usa una funcion para conectar el codigo con los botones de Unity
    public void ComprobarClaveIngresada()
    {
        string claveIngresada = inputClave.text;
        if(claveIngresada != clave)
        {
            txtMensaje.text = "Acceso denegado";
            inputClave.text = "";
        } 
        else
        {
            txtMensaje.text = "Bienvenido";
        }
    }
}
