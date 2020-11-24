using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneController : MonoBehaviour
{
    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene("Platformer");
    }

    public void OnRestartButtonPressed()
    {
        SceneManager.LoadScene("Platformer");
    }
}
