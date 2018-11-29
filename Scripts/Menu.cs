using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {

    private void OnMouseUpAsButton()
    {
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
            case "Quit":
                Application.Quit();
                break;
        }
    }
}
