using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvents : MonoBehaviour
{
    int seviye;
    Button button;
    private void Start()
    {
        button = GetComponent<Button>();
        button.interactable = false;

        GameObject.Find("Seviye" + 1).GetComponent<Button>().interactable = true;

        for (int i = 2; i < 10; i++)
        {
            if (PlayerPrefs.HasKey("seviye"))
            {
                PlayerPrefs.GetInt("seviye", i);
                GameObject.Find("Seviye" + i).GetComponent<Button>().interactable = true;

            }
        }

    }
    public void PointerEnter()
    {
        if (button.interactable)
        {
            transform.localScale = new Vector2(1f, 1f);
        }
    }

    public void PointerExit()
    {
        transform.localScale = new Vector2(1f, 1f);
    }


}

