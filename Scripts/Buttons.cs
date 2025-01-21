using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject m_on, m_off;
    public Sprite layer_blue, layer_red;

    void Start()
    {
        if (gameObject.name == "Music")
        {
            if (PlayerPrefs.GetString("Music") == "no")
            {
                m_on.SetActive(false);
                m_off.SetActive(true);
            }
            else
            {
                m_on.SetActive(true);
                m_off.SetActive(false);
            }
        }
    }

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = layer_red;
    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = layer_blue;
    }

    private void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("ClickAudio").GetComponent<AudioSource>().Play();
        switch (gameObject.name)
        {
            case "Play":
                Application.LoadLevel("Play");
                break;

            case "Rating":
                Application.OpenURL("");
                break;

            case "Replay":
                Application.LoadLevel("Play");
                break;

            case "Home":
                Application.LoadLevel("Start");
                break;

            case "Share":
                Application.OpenURL("https://www.youtube.com/");
                break;

            case "How to":
                Application.LoadLevel("HowTo");
                break;

            case "Close":
                Application.LoadLevel("Start");
                break;

            case "Music":
                if (PlayerPrefs.GetString("Music") != "no")
                {
                    PlayerPrefs.SetString("Music", "no");
                    m_on.SetActive(false);
                    m_off.SetActive(true);
                }
                else
                {
                    PlayerPrefs.SetString("Music", "yes");
                    m_on.SetActive(true);
                    m_off.SetActive(false);
                }
                break;
        }
    }
}
