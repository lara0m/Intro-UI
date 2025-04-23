using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaveManager : MonoBehaviour
{
    public TMP_InputField inputClave;
    public TMP_InputField inputUsuario;
    public TextMeshProUGUI txtMensaje;

    string clave = "tic2025";
    string usuario = "lara_0";
    // Start is called before the first frame update
    void Start()
    {
        txtMensaje.text = "";

    }
    
    // siempre se usa una funcion para conectar el codigo con los botones de Unity
    public void ComprobarClaveIngresada()
    {
        string claveIngresada = inputClave.text;
        string usuarioIngresado = inputUsuario.text;
        if(claveIngresada != clave || usuarioIngresado != usuario)
        {
            txtMensaje.text = "Acceso denegado";
            inputClave.text = "";
            inputUsuario.text = "";
        } 
        else
        {
            txtMensaje.text = "Bienvenido";
        }
    }
}
