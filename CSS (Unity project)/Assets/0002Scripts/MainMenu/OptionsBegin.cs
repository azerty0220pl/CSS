using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsBegin : MonoBehaviour
{
    private void Start()
    {
        ChangeResolution();
    }
    // Update is called once per frame
    public void Change()
    {
        SceneManager.LoadScene(1);
    }

    private void ChangeResolution()
    {
        if (PlayerPrefs.GetInt("resolution") == 0)
        {
            Screen.SetResolution(1024, 576, true);
        }
        else if (PlayerPrefs.GetInt("resolution") == 1)
        {
            Screen.SetResolution(1152, 648, true);
        }
        else if (PlayerPrefs.GetInt("resolution") == 2)
        {
            Screen.SetResolution(1280, 720, true);
        }
        else if (PlayerPrefs.GetInt("resolution") == 3)
        {
            Screen.SetResolution(1366, 768, true);
        }
        else if (PlayerPrefs.GetInt("resolution") == 4)
        {
            Screen.SetResolution(1600, 900, true);
        }
        else if (PlayerPrefs.GetInt("resolution") == 5)
        {
            Screen.SetResolution(1920, 1080, true);
        }
        else if (PlayerPrefs.GetInt("resolution") == 6)
        {
            Screen.SetResolution(2560, 1440, true);
        }
        else if (PlayerPrefs.GetInt("resolution") == 7)
        {
            Screen.SetResolution(3840, 2160, true);
        }
        else if (PlayerPrefs.GetInt("resolution") == 8)
        {
            Screen.SetResolution(7680, 4320, true);
        }
    }
}
