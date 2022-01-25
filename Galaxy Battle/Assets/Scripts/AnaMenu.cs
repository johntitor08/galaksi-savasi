using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenu : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PlayMenu()
    {
        SceneManager.LoadScene("PlayMenu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
