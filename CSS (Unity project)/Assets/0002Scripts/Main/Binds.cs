using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class Binds : MonoBehaviour
{
    public GameObject light;
    public GameObject music;
    public GameObject spaceship;
    public GameObject CSS;
    public GameObject Explosion;

    private void Start()
    {
        music.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("volume");

        GetComponent<FirstPersonController>().enabled = false;

        transform.position = new Vector3(PlayerPrefs.GetFloat("xPosKowalski"), PlayerPrefs.GetFloat("yPosKowalski"), PlayerPrefs.GetFloat("zPosKowalski"));
        transform.eulerAngles = new Vector3(PlayerPrefs.GetFloat("xRotKowalski"), PlayerPrefs.GetFloat("yRotKowalski"), PlayerPrefs.GetFloat("zRotKowalski"));
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            PlayerPrefs.SetFloat("xPosKowalski", transform.position.x);
            PlayerPrefs.SetFloat("yPosKowalski", transform.position.y);
            PlayerPrefs.SetFloat("zPosKowalski", transform.position.z);

            PlayerPrefs.SetFloat("xRotKowalski", transform.rotation.x);
            PlayerPrefs.SetFloat("yRotKowalski", transform.rotation.y);
            PlayerPrefs.SetFloat("zRotKowalski", transform.rotation.z);

            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            light.SetActive(!light.activeInHierarchy);
        }

        GetComponent<FirstPersonController>().enabled = true;

        if (PlayerPrefs.GetInt("transport1") == 1)
        {
            spaceship.SetActive(true);
        } else if (PlayerPrefs.GetInt("transport1") == 2)
        {
            PlayerPrefs.SetInt("transport1", 0);
            CSS.SetActive(false);
            gameObject.SetActive(false);
            Explosion.SetActive(true);
        }
    }
}
