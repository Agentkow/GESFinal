using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour {

    private void Start()
    {
        Cursor.visible = true;
    }

    public void QuitButtonClicked()
    {
        //close game
        Application.Quit();
    }

    public void ResetButtonClicked()
    {

        SceneManager.LoadScene("Level_1");
    }
}
