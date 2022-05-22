using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasena : MonoBehaviour
{

    string contrasenaCorrecta;
    string contrasenaUsuario;
    public Text ingresoUsuario;
    public Text textoMsj;
    public GameObject cartelitoMsj;

    // Start is called before the first frame update
    void Start()
    {
        contrasenaCorrecta = "12345";
        cartelitoMsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContrasena()
    {
        contrasenaUsuario = ingresoUsuario.text;
        if (contrasenaUsuario == contrasenaCorrecta)
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }

        else
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Contraseña Incorrecta";
            Debug.Log("Contraseña Incorrecta");
        }
    }
}
