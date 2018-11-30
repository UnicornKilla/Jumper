using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {

    public GameObject m_on, m_off;

    private void Start()
    {
        if (gameObject.name == "Sound") { 
            if (PlayerPrefs.GetString("Sound") == "no")
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

    private void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetString("Sound") != "no")
           GameObject.Find ("ClickAudio").GetComponent<AudioSource>().Play();

        switch (gameObject.name)
        {
            case "Play":
                SceneManager.LoadScene(1);
                break;
        }

        switch (gameObject.name)
        {
            case "HowToPlay":
                SceneManager.LoadScene(2);
                break;
        }

        switch (gameObject.name)
        {
            case "Back":
                SceneManager.LoadScene(0);
                break;
        }

        switch (gameObject.name)
        {
            case "Shop":
                SceneManager.LoadScene(3);
                break;
        }

        switch (gameObject.name)
        {
            case "Sound":
                if (PlayerPrefs.GetString("Sound") != "no")
                {
                    PlayerPrefs.SetString("Sound", "no");
                    m_on.SetActive(false);
                    m_off.SetActive(true);
                }               
                else
                {
                    PlayerPrefs.SetString("Sound", "yes");
                    m_on.SetActive(true);
                    m_off.SetActive(false);
                }
                break;
        }

        switch (gameObject.name)
        {
            case "Quit":
                Application.Quit();
                break;
        }
    }
}
