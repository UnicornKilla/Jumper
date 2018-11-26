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
            case "Quit":
                Application.Quit();
                break;
        }
    }
}
