using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class getData : MonoBehaviour
{
    public Text nombre, apellido, municipio, comunidad;
    public Button btnDelete;
    // Start is called before the first frame update
    void Start()
    {
        nombre.text = PlayerPrefs.GetString("nombre");
        apellido.text = PlayerPrefs.GetString("apellido");
        municipio.text = PlayerPrefs.GetString("municipio");
        comunidad.text = PlayerPrefs.GetString("comunidad");
    }

    // Update is called once per frame
    //Borrar los datos que se almacenaron
    public void eraserPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Uno_Intro");
    }
}
