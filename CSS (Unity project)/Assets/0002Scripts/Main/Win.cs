using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    private void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void menu()
    {
        PlayerPrefs.SetInt("transport1", 0);
        SceneManager.LoadScene(0);
    }
}
