using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContra : MonoBehaviour
{
    string contraseñacorrecta;
    string contrausuario;
    public Text ingresousuario;
    public Text textomsj;
    public GameObject cartelitomsj;

    // Start is called before the first frame update
    void Start()
    {
        contraseñacorrecta = "12345";
        cartelitomsj.SetActive(false);
    }

    public void validarcontraseña()
    {
        contrausuario = ingresousuario.text;
        if (contrausuario == contraseñacorrecta)
        {
            Debug.Log("Bienvenido");
            cartelitomsj.SetActive(true);
            textomsj.text = "Bienvenido";

        }
        else
        {
            Debug.Log("Contraseña incorrecta");
            cartelitomsj.SetActive(true);
            textomsj.text = "Contraseña incorrecta";
        }
    }
}
