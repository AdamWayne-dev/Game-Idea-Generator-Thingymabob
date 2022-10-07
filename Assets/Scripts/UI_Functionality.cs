using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Functionality : MonoBehaviour
{
    [Header("Toggles")]
    [SerializeField] Toggle toggle1;
    [SerializeField] Toggle toggle2;
    

    [Header("Game Objects")]
    [SerializeField] GameObject genre1;
    [SerializeField] GameObject genre2;

    [Header("Input Fields")]
    [SerializeField] GameObject custom_input_1;
    [SerializeField] GameObject custom_input_2;

    [Header("Dropdown Lists")]
    [SerializeField] TMP_Dropdown dropdown_1;
    [SerializeField] TMP_Dropdown dropdown_2;
    void Start()
    {
       
    }

    
    void Update()
    {
        Toggle_always_active();
        if (toggle1.isOn)
        {
            Toggle_One_on();

            if(dropdown_1.options[dropdown_1.value].text == "Custom") // If toggle 1 is on and the value is set to 'Custom' then the custom text input field will appear.
            {
                custom_input_1.SetActive(true);
            }
            else
            {
                custom_input_1.SetActive(false);
            }
        }
        
        if (toggle2.isOn)
        {
            Toggle_Two_on();

            if (dropdown_1.options[dropdown_1.value].text == "Custom") // If toggle 1 and 2 is on and the value is set to 'Custom' then the custom text input field will appear.
            {
                custom_input_1.SetActive(true);
            }
            else
            {
                custom_input_1.SetActive(false);
            }

            if (dropdown_2.options[dropdown_2.value].text == "Custom")
            {
                custom_input_2.SetActive(true);
            }
            else
            {
                custom_input_2.SetActive(false);
            }
        }

        

    }

    public void Toggle_One_on()
    {
        genre2.SetActive(false); // Hides genre2 game object if only '1 genre' is toggled.
    }

    public void Toggle_Two_on()
    {
        genre2.SetActive(true); //Shows genre2 game object if '2 genres' is toggled.
    }

    public void Toggle_always_active() // Makes sure one of the toggles is always on.
    {
        if (!toggle1.isOn)
        {
            toggle2.isOn = true;
        }

        else
        {
            toggle1.isOn = true;
        }
    }
    
}
