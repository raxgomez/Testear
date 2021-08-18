using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes_ovalle : MonoBehaviour
{
    public void cargarEscena(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
