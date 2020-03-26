using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ComputerScript : MonoBehaviour
{
    public InputField inputField;
    public string inputCommand;
    public GameObject textObject;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        inputField.enabled = true;
        Cursor.visible = false;
        inputField.ActivateInputField();
        text = textObject.GetComponent<Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {

            inputCommand = inputField.text;
            inputField.text = "";
            text.text = text.text + "\n>>>> " + inputCommand;

            inputField.ActivateInputField();

            if (inputCommand == "help")
            {
                Debug.Log("working");
                text.text = text.text + "\n Common commands: \n EndTutorial - Tutorial will be ended\n LightDisable - Lights will be disabled\n LightEnable - Lights will be enablad \n exit - Log out";
            }
            else if (inputCommand == "LightDisable")
            {
                PlayerPrefs.SetInt("LightTutorial", 0);
                text.text = text.text + "\n Lights are disabled.";
            }
            else if (inputCommand == "LightEnable")
            {
                PlayerPrefs.SetInt("LightTutorial", 1);
                text.text = text.text + "\n Lights are enabled.";
            }
            else if (inputCommand == "EndTutorial")
            {
                SceneManager.LoadScene(0);
            }
            else if (inputCommand == "exit")
            {
                SceneManager.LoadScene(4);
            }
        }
    }
}
