using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerReaktor : MonoBehaviour
{
    public InputField inputField;
    public string inputCommand;
    public GameObject textObject;

    Text textText;

    bool left1 = true;
    bool left2 = true;
    bool left3 = true;
    bool left4 = true;

    bool middle1 = false;
    bool middle2 = false;
    bool middle3 = false;
    bool middle4 = false;

    bool right1 = false;
    bool right2 = false;
    bool right3 = false;
    bool right4 = false;

    int level = 0;

    int phase = 0;

    public Scrollbar scroll;

    // Start is called before the first frame update
    void Start()
    {
        textText = textObject.GetComponent<Text>();
        inputField.enabled = true;
        Cursor.visible = false;
        inputField.ActivateInputField();
        textText.text = "	To power on the station, transfer the energy to the right terminal.\n   Energy from the first level can be transfered everywhere.\n   Energy from other levels can be transfered to other terminals only if there is no energy on any level above. Otherwise, energy positions will reset.\n   Terminal status: (energy = +/ no energy = -)\n +- -\n +- -\n +- -\n +- -\n   From which terminal do you wish to transfer the energy from? \n left / middle / right ";
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("lightCSS") == 0)
        {
            LightDisable();
        }
        else
        {
            textText.text = "Power on.";
            if (Input.GetKeyUp(KeyCode.Return))
            {
                inputCommand = inputField.text;
                inputField.text = "";
                textText.text = textText.text + "\n>>>> " + inputCommand;
                inputField.ActivateInputField();

                if (inputCommand == "reset")
                {
                    PlayerPrefs.SetInt("lightCSS", 0);

                    left1 = true;
                    left2 = true;
                    left3 = true;
                    left4 = true;

                    middle1 = false;
                    middle2 = false;
                    middle3 = false;
                    middle4 = false;

                    right1 = false;
                    right2 = false;
                    right3 = false;
                    right4 = false;

                    phase = 0;

                    textText.text = "	To power on the station, transfer the energy to the right terminal.\n   Energy from the first level can be transfered everywhere.\n   Energy from other levels can be transfered to other terminals only if there is no energy on any level above. Otherwise, energy positions will reset.\n   Terminal status: (energy = +/ no energy = -)\n +- -\n +- -\n +- -\n +- -\n   From which terminal do you wish to transfer the energy from? \n left / middle / right ";
                }
            }
        }
    }

    void LightDisable()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            inputCommand = inputField.text;
            inputField.text = "";
            textText.text = textText.text + "\n>>>> " + inputCommand;

            inputField.ActivateInputField();

            if (phase == 0)
            {
                if (inputCommand == "left")
                {
                    if (left1 == true)
                    {
                        textText.text = textText.text + "\n To which terminal do you wish to transfer the energy?";
                        phase = 1;
                        level = 1;
                        left1 = false;
                    }
                    else if (left2 == true)
                    {
                        textText.text = textText.text + "\n To which terminal do you wish to transfer the energy?";
                        phase = 1;
                        level = 2;
                        left2 = false;
                    }
                    else if (left3 == true)
                    {
                        textText.text = textText.text + "\n To which terminal do you wish to transfer the energy?";
                        phase = 1;
                        level = 3;
                        left3 = false;
                    }
                    else if (left4 == true)
                    {
                        textText.text = textText.text + "\n To which terminal do you wish to transfer the energy?";
                        phase = 1;
                        level = 4;
                        left4 = false;
                    }
                    else
                    {
                        textText.text = textText.text + "\n The terminal is empty.";
                    }
                }

                if (inputCommand == "middle")
                {
                    if (middle1 == true)
                    {
                        textText.text = textText.text + "\n To which terminal do you wish to transfer the energy?";
                        phase = 1;
                        level = 1;
                        middle1 = false;
                    }
                    else if (middle2 == true)
                    {
                        textText.text = textText.text + "\n To which terminal do you wish to transfer the energy?";
                        phase = 1;
                        level = 2;
                        middle2 = false;
                    }
                    else if (middle3 == true)
                    {
                        textText.text = textText.text + "\n To which terminal do you wish to transfer the energy?";
                        phase = 1;
                        level = 3;
                        middle3 = false;
                    }
                    else if (middle4 == true)
                    {
                        textText.text = textText.text + "\n To which terminal do you wish to transfer the energy?";
                        phase = 1;
                        level = 4;
                        middle4 = false;
                    }
                    else
                    {
                        textText.text = textText.text + "\n The terminal is empty.";
                    }
                }

                if (inputCommand == "right")
                {
                    if (right1 == true)
                    {
                        textText.text = textText.text + "\n To which terminal do you wish to transfer the energy?";
                        phase = 1;
                        level = 1;
                        right1 = false;
                    }
                    else if (right2 == true)
                    {
                        textText.text = textText.text + "\n To which terminal do you wish to transfer the energy?";
                        phase = 1;
                        level = 2;
                        right2 = false;
                    }
                    else if (right3 == true)
                    {
                        textText.text = textText.text + "\n To which terminal do you wish to transfer the energy?";
                        phase = 1;
                        level = 3;
                        right3 = false;
                    }
                    else if (right4 == true)
                    {
                        textText.text = textText.text + "\n To which terminal do you wish to transfer the energy?";
                        phase = 1;
                        level = 4;
                        right4 = false;
                    }
                    else
                    {
                        textText.text = textText.text + "\n The terminal is empty.";
                    }
                }
            }
            else if (phase == 1)
            {
                if (inputCommand == "left")
                {
                    if (level == 1)
                    {
                        left1 = true;
                        phase = 0;
                        textText.text = textText.text + "\n Transfer status: 'succes'.";
                    }
                    else if (level == 2 && left1 == false)
                    {
                        left2 = true;
                        phase = 0;
                        textText.text = textText.text + "\n Transfer status: 'succes'.";
                    }
                    else if (level == 3 && left1 == false && left2 == false)
                    {
                        left3 = true;
                        phase = 0;
                        textText.text = textText.text + "\n Transfer status: 'succes'.";
                    }
                    else if (level == 4 && left1 == false && left2 == false && left3 == false)
                    {
                        left4 = true;
                        phase = 0;
                        textText.text = textText.text + "\n Transfer status: 'succes'.";
                    }
                }

                if (inputCommand == "middle")
                {
                    if (level == 1)
                    {
                        middle1 = true;
                        phase = 0;
                        textText.text = textText.text + "\n Transfer status: 'succes'.";
                    }
                    else if (level == 2 && middle1 == false)
                    {
                        middle2 = true;
                        phase = 0;
                        textText.text = textText.text + "\n Transfer status: 'succes'.";
                    }
                    else if (level == 3 && middle1 == false && middle2 == false)
                    {
                        middle3 = true;
                        phase = 0;
                        textText.text = textText.text + "\n Transfer status: 'succes'.";
                    }
                    else if (level == 4 && middle1 == false && middle2 == false && middle3 == false)
                    {
                        middle4 = true;
                        phase = 0;
                        textText.text = textText.text + "\n Transfer status: 'succes'.";
                    }
                }

                if (inputCommand == "right")
                {
                    if (level == 1)
                    {
                        right1 = true;
                        phase = 0;
                        textText.text = textText.text + "\n Transfer status: 'succes'.";
                    }
                    else if (level == 2 && right1 == false)
                    {
                        right2 = true;
                        phase = 0;
                        textText.text = textText.text + "\n Transfer status: 'succes'.";
                    }
                    else if (level == 3 && right1 == false && right2 == false)
                    {
                        right3 = true;
                        phase = 0;
                        textText.text = textText.text + "\n Transfer status: 'succes'.";
                    }
                    else if (level == 4 && right1 == false && right2 == false && right3 == false)
                    {
                        right4 = true;
                        phase = 0;
                        textText.text = textText.text + "\n Transfer status: 'succes'.";
                    }
                    else
                    {
                        textText.text = textText.text + "\n Error. Reseting...";
                        left1 = true;
                        left2 = true;
                        left3 = true;
                        left4 = true;

                        right1 = false;
                        right2 = false;
                        right3 = false;
                        right4 = false;

                        middle1 = false;
                        middle2 = false;
                        middle3 = false;
                        middle4 = false;
                        phase = 0;
                    }
                }
            }
        }

        if (right1 == true && right2 == true && right3 == true && right4 == true)
        {
            PlayerPrefs.SetInt("lightCSS", 1);
        }
    }
}
