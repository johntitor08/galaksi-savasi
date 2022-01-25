using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonEvents : MonoBehaviour
{
    Animator anim;
    Button button;
    private void Start()
    {
        anim = GetComponent<Animator>();
        button = GetComponent<Button>();

        if (SceneManager.GetActiveScene().name == "PlayMenu")
        {
            button.interactable = false;
            GameObject.Find("Seviye" + 1).GetComponent<Button>().interactable = true;

        }

        for (int i = 2; i < 10; i++)
        {
            if (PlayerPrefs.HasKey("seviye" + i))
            {
                PlayerPrefs.GetInt("seviye", i);
                GameObject.Find("Seviye" + i).GetComponent<Button>().interactable = true;

            }
        }

    }

    public void PointerEnter(int i)
    {
        if (SceneManager.GetActiveScene().name == "PlayMenu" && button.interactable)
        {
            anim.SetTrigger("buton" + i);
        }

    }


    public void OynaButtonAnim()
    {
        anim.SetTrigger("oyna");
    }

    public void CikisButtonAnim()
    {
        anim.SetTrigger("cikis");
    }

}

