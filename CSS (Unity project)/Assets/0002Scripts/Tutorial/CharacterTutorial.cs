using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterTutorial : MonoBehaviour
{
    public GameObject torch;
    public GameObject character;
    public GameObject door1;
    public GameObject door2;
    int stateDoor1 = 0;
    int stateDoor2 = 0;
    int touching1 = 0;
    int touching2 = 0;
    int touching3 = 0;

    private void Start()
    {
        character.transform.position = new Vector3(PlayerPrefs.GetFloat("CharacterXTutorial"), PlayerPrefs.GetFloat("CharacterYTutorial") + 0.5f, PlayerPrefs.GetFloat("CharacterZTutorial"));
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            PlayerPrefs.SetFloat("CharacterXTutorial", character.transform.position.x);
            PlayerPrefs.SetFloat("CharacterYTutorial", character.transform.position.y);
            PlayerPrefs.SetFloat("CharacterZTutorial", character.transform.position.z); 

            SceneManager.LoadScene(1);
        }

        if (touching1 == 1)
        {
            if (Input.GetKeyDown(KeyCode.E) && stateDoor1 == 0)
            {
                door1.GetComponent<Animator>().SetBool("character_nearby", true);
                stateDoor1 = 1;
                //Debug.Log("opening");
            }else if (Input.GetKeyDown(KeyCode.E) && stateDoor1 == 1)
            {
                door1.GetComponent<Animator>().SetBool("character_nearby", false);
                stateDoor1 = 0;
                //Debug.Log("Closing");
            }
        }

        if (touching2 == 1)
        {
            if (Input.GetKeyDown(KeyCode.E) && stateDoor2 == 0)
            {
                door2.GetComponent<Animator>().SetBool("character_nearby", true);
                stateDoor2 = 1;
                //Debug.Log("opening");
            } else if (Input.GetKeyDown(KeyCode.E) && stateDoor2 == 1)
            {
                door2.GetComponent<Animator>().SetBool("character_nearby", false);
                stateDoor2 = 0;
                //Debug.Log("Closing");
            }
        }

        if (touching3 == 1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerPrefs.SetFloat("CharacterXTutorial", character.transform.position.x);
                PlayerPrefs.SetFloat("CharacterYTutorial", character.transform.position.y);
                PlayerPrefs.SetFloat("CharacterZTutorial", character.transform.position.z);
                SceneManager.LoadScene(5);
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            torch.SetActive(!torch.activeInHierarchy);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "glass_panel_1_with_door" || other.gameObject.name == "glass_panel_1_door")
        {
            touching1 = 1;
        }
        else
        {
            touching1 = 0;
        }

        if (other.gameObject.name == "door_1_left" || other.gameObject.name == "door_1_right")
        {
            touching2 = 1;
        }
        else
        {
            touching2 = 0;
        }

        if (other.gameObject.name == "desk" || other.gameObject.name == "pilot_seat")
        {
            touching3 = 1;
        }
        else
        {
            touching3 = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        touching1 = 0;
        touching2 = 0;
        touching3 = 0;
    }
}
