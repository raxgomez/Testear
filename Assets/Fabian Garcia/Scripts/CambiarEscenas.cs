using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenas : MonoBehaviour
{
    public void cambiarEscenas(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
