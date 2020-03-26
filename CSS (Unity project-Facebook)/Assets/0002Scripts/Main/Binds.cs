using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class Binds : MonoBehaviour
{
    public GameObject light;
    public GameObject stick;
    public GameObject music;
    public GameObject spaceship;
    public GameObject CSS;
    public GameObject Explosion;
    int hitState = 1;

    private void Start()
    {
        music.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("volume");

        GetComponent<FirstPersonController>().enabled = false;

        hitState = 0;

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

        if (Input.GetMouseButtonDown(0))
        {
            hitState = 1;
        }

        if (hitState == 1)
        {
            hit();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            light.SetActive(!light.activeInHierarchy);
            stick.SetActive(!stick.activeInHierarchy);
        }

        GetComponent<FirstPersonController>().enabled = true;

        if (PlayerPrefs.GetInt("transport1") == 1)
        {
            spaceship.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("transport1") == 2)
        {
            PlayerPrefs.SetInt("transport1", 0);
            CSS.SetActive(false);
            gameObject.SetActive(false);
            Explosion.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("transport1") == 220)
        {
            PlayerPrefs.SetInt("transport1", 0);

            GetComponent<FirstPersonController>().enabled = false;
            transform.position = new Vector3(-1870.4f, 171.2f, -134.9f);
        }
    }

    void hit()
    {
        Vector3 angles = new Vector3(stick.transform.eulerAngles.x + 10, stick.transform.eulerAngles.y, stick.transform.eulerAngles.z + 10);
        stick.transform.eulerAngles = angles;

        if (stick.transform.eulerAngles.x >= 45 && stick.transform.eulerAngles.z >= 45)
        {
            Quaternion angle = new Quaternion(0, 0, 0, 0);
            stick.transform.rotation = angle;
            hitState = 0;
        }
    }
}
