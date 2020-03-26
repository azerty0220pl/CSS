using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public Dropdown resolution;
    public GameObject sens;
    public GameObject volume;

    private void Start()
    {
        volume.GetComponent<Slider>().value = PlayerPrefs.GetFloat("volume");
        resolution.value = PlayerPrefs.GetInt("resolution");
        ChangeResolution();
        sens.GetComponent<Slider>().value = PlayerPrefs.GetFloat("sens");
        volume.GetComponent<Slider>().value = PlayerPrefs.GetFloat("volume");
    }

    private void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void SensChange()
    {
        PlayerPrefs.SetFloat("sens", sens.GetComponent<Slider>().value);
    }

    public void VolumeChange()
    {
        PlayerPrefs.SetFloat("volume", volume.GetComponent<Slider>().value);
    }

    public void ChangeResolution()
    {
        if (resolution.value == 0)
        {
            Screen.SetResolution(1024, 576, true);
            Debug.Log(Screen.resolutions);
        }
        else if(resolution.value == 1)
        {
            Screen.SetResolution(1152, 648, true);
            Debug.Log(Screen.resolutions);
        }
        else if (resolution.value == 2)
        {
            Screen.SetResolution(1280, 720, true);
            Debug.Log(Screen.resolutions);
        }
        else if (resolution.value == 3)
        {
            Screen.SetResolution(1366, 768, true);
            Debug.Log(Screen.resolutions);
        }
        else if (resolution.value == 4)
        {
            Screen.SetResolution(1600, 900, true);
            Debug.Log(Screen.resolutions);
        }
        else if (resolution.value == 5)
        {
            Screen.SetResolution(1920, 1080, true);
            Debug.Log(Screen.resolutions);
        }
        else if (resolution.value == 6)
        {
            Screen.SetResolution(2560, 1440, true);
            Debug.Log(Screen.resolutions);
        }
        else if (resolution.value == 7)
        {
            Screen.SetResolution(3840, 2160, true);
            Debug.Log(Screen.resolutions);
        }
        else if (resolution.value == 8)
        {
            Screen.SetResolution(7680, 4320, true);
            Debug.Log(Screen.resolutions);
        }

        PlayerPrefs.SetInt("resolution", resolution.value);
        Debug.Log(resolution.value);
    }

    public void Return()
    {
        SceneManager.LoadScene(0);
    }
}
