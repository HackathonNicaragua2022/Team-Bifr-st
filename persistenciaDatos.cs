using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class persistenciaDatos : MonoBehaviour
{
    public Button btnRegistrate, btnIngresar;
    public InputField nombre, apellido, seccion, turno;

    public TextMeshProUGUI datosGuardados, IngreseDatos;
    // Start is called before the first frame update
    void Start()
    {
        btnIngresar.gameObject.SetActive(false);
        datosGuardados.gameObject.SetActive(false);
        IngreseDatos.gameObject.SetActive(false);
        
        if(PlayerPrefs.GetString("nombre")!="")
        {
            
            SceneManager.LoadScene("Cuatro_Main_Menu");
        }
    }

    //Guardar datos del usuario
    public void saveString()
    {
        string nombreUsuario = nombre.text;
        PlayerPrefs.SetString("nombre", nombreUsuario);

        string apellidoUsuario = apellido.text;
        PlayerPrefs.SetString("apellido", apellidoUsuario);

        string municipioUsuario = seccion.text;
        PlayerPrefs.SetString("seccion", municipioUsuario);

        string comunidadUsuario = turno.text;
        PlayerPrefs.SetString("turno", comunidadUsuario);


        //Si la cadena esta vacia entrar con el ultimo registro del usuario
        if(PlayerPrefs.GetString("nombre") =="")
        {
            datosGuardados.gameObject.SetActive(false);
            btnIngresar.gameObject.SetActive(false);
            IngreseDatos.gameObject.SetActive(true);
        }
        else
        {
            IngreseDatos.gameObject.SetActive(false);
            datosGuardados.gameObject.SetActive(true);
            btnIngresar.gameObject.SetActive(true);
        }
    }

    public void readString()
    {
        SceneManager.LoadScene("Tres_Instrucciones");
    }
}
