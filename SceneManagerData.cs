using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerData : MonoBehaviour
{
    //Cambio de escenas
    public void LoadScene(string scenename)
    {
        //Referencia a el cambio de escena
        SceneManager.LoadScene(scenename);
    }
}
