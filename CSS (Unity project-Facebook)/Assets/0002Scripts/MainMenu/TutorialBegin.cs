using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialBegin : MonoBehaviour
{
    private void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    public void Change()
    {
        PlayerPrefs.SetInt("LightTutorial", 0);
        PlayerPrefs.SetFloat("CharacterXTutorial", 0);
        PlayerPrefs.SetFloat("CharacterYTutorial", 2);
        PlayerPrefs.SetFloat("CharacterZTutorial", 0);
        SceneManager.LoadScene(4);
    }

    public void NewGame()
    {
        PlayerPrefs.SetInt("LightTutorial", 0);
        PlayerPrefs.SetFloat("xPosKowalski", 0);
        PlayerPrefs.SetFloat("yPosKowalski", 2);
        PlayerPrefs.SetFloat("zPosKowalski", 0);

        PlayerPrefs.SetFloat("xRotKowalski", 0);
        PlayerPrefs.SetFloat("yRotKowalski", 0);
        PlayerPrefs.SetFloat("zRotKowalski", 0);

        PlayerPrefs.SetInt("l11", 1);
        PlayerPrefs.SetInt("l12", 1);
        PlayerPrefs.SetInt("l13", 1);
        PlayerPrefs.SetInt("l14", 1);
        PlayerPrefs.SetInt("l11o", 0);
        PlayerPrefs.SetInt("l12o", 0);
        PlayerPrefs.SetInt("l13o", 0);
        PlayerPrefs.SetInt("l14o", 0);
        PlayerPrefs.SetInt("l21", 0);
        PlayerPrefs.SetInt("l22", 0);
        PlayerPrefs.SetInt("l23", 0);
        PlayerPrefs.SetInt("l24", 0);
        PlayerPrefs.SetInt("l21o", 1);
        PlayerPrefs.SetInt("l22o", 1);
        PlayerPrefs.SetInt("l23o", 1);
        PlayerPrefs.SetInt("l24o", 1);
        PlayerPrefs.SetInt("l31", 0);
        PlayerPrefs.SetInt("l32", 0);
        PlayerPrefs.SetInt("l33", 0);
        PlayerPrefs.SetInt("l34", 0);
        PlayerPrefs.SetInt("l31o", 1);
        PlayerPrefs.SetInt("l32o", 1);
        PlayerPrefs.SetInt("l33o", 1);
        PlayerPrefs.SetInt("l34o", 1);
        PlayerPrefs.SetInt("b11", 1);
        PlayerPrefs.SetInt("b12", 1);
        PlayerPrefs.SetInt("b13", 1);
        PlayerPrefs.SetInt("b14", 1);
        PlayerPrefs.SetInt("b11o", 0);
        PlayerPrefs.SetInt("b12o", 0);
        PlayerPrefs.SetInt("b13o", 0);
        PlayerPrefs.SetInt("b14o", 0);
        PlayerPrefs.SetInt("b21", 1);
        PlayerPrefs.SetInt("b22", 1);
        PlayerPrefs.SetInt("b23", 1);
        PlayerPrefs.SetInt("b24", 1);
        PlayerPrefs.SetInt("b21o", 0);
        PlayerPrefs.SetInt("b22o", 0);
        PlayerPrefs.SetInt("b23o", 0);
        PlayerPrefs.SetInt("b24o", 0);

        SceneManager.LoadScene(2);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(2);
    }
}
