using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void Seviye(int i)
    {
        SceneManager.LoadScene("Level" + i);
    }

    public void SeviyeBitir(int i)
    {
        SceneManager.LoadScene("Level" + (i + 1));

        PlayerPrefs.SetInt("seviye" + i + 1, 1);

    }

}
