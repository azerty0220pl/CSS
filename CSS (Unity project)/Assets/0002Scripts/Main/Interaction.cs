using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour
{
    public GameObject AstroDoor;
    public GameObject AstrogatorBed;
    public GameObject InfDoor;
    public GameObject AstDoor;
    public GameObject EngDoor;
    public GameObject SilDoor;
    public GameObject ToiDoor;
    public GameObject LibDoor;
    public GameObject SteDoor;
    public GameObject Kowalski;
    public GameObject PanelSilnia;
    public GameObject SterowniaComputer;
    public GameObject KomputerBiblia;
    public GameObject ship;

    int AstroState;
    int AstState;
    int AstrogatorState;
    int EngState;
    int InfState;
    int SilState;
    int LibState;
    int ToiState;
    int SteState;
    int PanState;
    int CompSte;
    int KompBiblia;
    int win;

    void Start()
    {
        PanelSilnia.GetComponent<PanelSilnia>().Start();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (AstroState == 1)
            {
                AstroDoor.GetComponent<Animator>().SetBool("character_nearby", !AstroDoor.GetComponent<Animator>().GetBool("character_nearby"));
            }
            else if (AstState == 1)
            {
                AstDoor.GetComponent<Animator>().SetBool("character_nearby", !AstDoor.GetComponent<Animator>().GetBool("character_nearby"));
            }
            else if (EngState == 1)
            {
                EngDoor.GetComponent<Animator>().SetBool("character_nearby", !EngDoor.GetComponent<Animator>().GetBool("character_nearby"));
                Debug.Log("EngDoor");
            }
            else if (SilState == 1)
            {
                SilDoor.GetComponent<Animator>().SetBool("character_nearby", !SilDoor.GetComponent<Animator>().GetBool("character_nearby"));
            }
            else if (AstrogatorState == 1)
            {
                AstrogatorBed.GetComponent<Animator>().SetBool("character_nearby", !AstrogatorBed.GetComponent<Animator>().GetBool("character_nearby"));
            }
            else if (ToiState == 1)
            {
                ToiDoor.GetComponent<Animator>().SetBool("character_nearby", !ToiDoor.GetComponent<Animator>().GetBool("character_nearby"));
            }
            else if (InfState == 1)
            {
                InfDoor.GetComponent<Animator>().SetBool("character_nearby", !InfDoor.GetComponent<Animator>().GetBool("character_nearby"));
            }
            else if (LibState == 1)
            {
                LibDoor.GetComponent<Animator>().SetBool("character_nearby", !LibDoor.GetComponent<Animator>().GetBool("character_nearby"));
            }
            else if (SteState == 1)
            {
                SteDoor.GetComponent<Animator>().SetBool("character_nearby", !SteDoor.GetComponent<Animator>().GetBool("character_nearby"));
            }
            else if (PanState == 1)
            {
                Kowalski.SetActive(false);
                PanelSilnia.SetActive(true);
            }
            else if (CompSte == 1 && PlayerPrefs.GetInt("lightsMain") == 1)
            {
                Kowalski.SetActive(false);
                SterowniaComputer.SetActive(true);
            }
            else if (KompBiblia == 1 && PlayerPrefs.GetInt("lightsMain") == 1)
            {
                Kowalski.SetActive(false);
                KomputerBiblia.SetActive(true);
            }
            else if (win == 1)
            {
                SceneManager.LoadScene(6);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "AstrDoor":
                AstroState = 1;
                break;
            case "AstDoor":
                AstState = 1;
                break;
            case "AstrogatorBed":
                AstrogatorState = 1;
                break;
            case "EngDoor":
                EngState = 1;
                break;
            case "InfDoor":
                InfState = 1;
                break;
            case "LibDoor":
                LibState = 1;
                break;
            case "ToiDoor":
                ToiState = 1;
                break;
            case "SteDoor":
                SteState = 1;
                break;
            case "SilDoor":
                SilState = 1;
                break;
            case "PanelSilnia":
                PanState = 1;
                break;
            case "SilniaKomp":
                CompSte = 1;
                break;
            case "KompBiblia":
                KompBiblia = 1;
                break;
            case "win":
                win = 1;
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        AstroState = 0;
        AstState = 0;
        AstrogatorState = 0;
        EngState = 0;
        InfState = 0;
        LibState = 0;
        ToiState = 0;
        SteState = 0;
        SilState = 0;
        PanState = 0;
        CompSte = 0;
        KompBiblia = 0;
        win = 0;
    }
}
