using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class UI_Functionality : MonoBehaviour
{
    [Header("Toggles")]
    [SerializeField] Toggle toggle1;
    [SerializeField] Toggle toggle2;
    

    [Header("Game Objects")]
    [SerializeField] GameObject genre1;
    [SerializeField] GameObject genre2;
    [SerializeField] GameObject subGenre1;
    [SerializeField] GameObject subGenre2;
    
    [Header("Dropdown Lists")]
    [SerializeField] TMP_Dropdown dropdown_1;
    [SerializeField] TMP_Dropdown dropdown_2;
    [SerializeField] TMP_Dropdown subGenre1_dropdown;
    [SerializeField] TMP_Dropdown subGenre2_dropdown;

    [Header("Scripts")]
    [SerializeField] SubGenres subGenres;

    List<string> action_subGenre_Selection;
    List<string> adventure_subGenre_Selection;
    List<string> rhythm_subGenre_Selection;
    List<string> puzzle_subGenre_Selection;
    List<string> rpg_subGenre_Selection;
    List<string> strategy_subGenre_Selection;
    List<string> sim_subGenre_Selection;
    List<string> sports_subGenre_Selection;
    List<string> casual_subGenre_Selection;

    
    bool loop_through = false;
    void Start()
    {
      action_subGenre_Selection = subGenres.Get_Action_Subgenres();
      adventure_subGenre_Selection = subGenres.Get_Adventure_Subgenres();
      rhythm_subGenre_Selection = subGenres.Get_Rhythm_Subgenres(); 
      puzzle_subGenre_Selection = subGenres.Get_Puzzle_Subgenres();
      rpg_subGenre_Selection = subGenres.Get_RPG_Subgenres();
      strategy_subGenre_Selection = subGenres.Get_Strategy_Subgenres();
      sim_subGenre_Selection = subGenres.Get_Sim_Subgenres();
      sports_subGenre_Selection = subGenres.Get_Sports_Subgenres();
      casual_subGenre_Selection = subGenres.Get_Casual_Subgenres();
    }

    
    void Update()
    {
        Toggle_always_active();
        Toggle1_Functionatlity();
        Toggle2_Functionatlity();
    }
    
    void Toggle1_Functionatlity()
    {
        if (toggle1.isOn)
        {
            Toggle_One_on();
            subGenre2.SetActive(false);
            Dropdown_1_Functionality();
        }
    }

    private void Dropdown_1_Functionality() // Sets the functionality of drop down 1
    {
        if (dropdown_1.options[dropdown_1.value].text == "Random")
        {
            subGenre1.SetActive(false); // Hides the subgenre options if Random is selected.

        }
        else
        {
            subGenre1.SetActive(true);
            Subgenre1_Input_Options();
           
        }
    }
    private void Dropdown_2_Functionality() // Sets the functionality of drop down 1
    {
        if (dropdown_2.options[dropdown_2.value].text == "Random")
        {
            subGenre2.SetActive(false); // Hides the subgenre options if Random is selected.

        }
        else
        {
            subGenre1.SetActive(true);
            Subgenre2_Input_Options();

        }
    }
    private void Subgenre1_Input_Options() // if custom is selected, it will reveal the custom field, else it will hide it.
    {
        string choice_text = dropdown_1.options[dropdown_1.value].text;
        if (loop_through) {
            switch (choice_text)
            {
                case "Action":
                    subGenre1_dropdown.ClearOptions();
                    subGenre1_dropdown.AddOptions(action_subGenre_Selection);

                    break;

                case "Adventure":
                    subGenre1_dropdown.ClearOptions();
                    subGenre1_dropdown.AddOptions(adventure_subGenre_Selection);

                    break;

                case "Rhythm":
                    subGenre1_dropdown.ClearOptions();
                    subGenre1_dropdown.AddOptions(rhythm_subGenre_Selection);

                    break;

                case "Puzzle":
                    subGenre1_dropdown.ClearOptions();
                    subGenre1_dropdown.AddOptions(puzzle_subGenre_Selection);

                    break;

                case "RPG":
                    subGenre1_dropdown.ClearOptions();
                    subGenre1_dropdown.AddOptions(rpg_subGenre_Selection);

                    break;

                case "Strategy":
                    subGenre1_dropdown.ClearOptions();
                    subGenre1_dropdown.AddOptions(strategy_subGenre_Selection);

                    break;

                case "Simulation":
                    subGenre1_dropdown.ClearOptions();
                    subGenre1_dropdown.AddOptions(sim_subGenre_Selection);

                    break;

                case "Sports":
                    subGenre1_dropdown.ClearOptions();
                    subGenre1_dropdown.AddOptions(sports_subGenre_Selection);

                    break;

                case "Casual":
                    subGenre1_dropdown.ClearOptions();
                    subGenre1_dropdown.AddOptions(casual_subGenre_Selection);

                    break;

                case "Random":
                    
                    break;
            }
        }
            
        
    }
    private void Subgenre2_Input_Options() // if custom is selected, it will reveal the custom field, else it will hide it.
    {
        string choice_text = dropdown_2.options[dropdown_2.value].text;
        if (loop_through)
        {
            switch (choice_text)
            {
                case "Action":
                    subGenre2_dropdown.ClearOptions();
                    subGenre2_dropdown.AddOptions(action_subGenre_Selection);

                    break;

                case "Adventure":
                    subGenre2_dropdown.ClearOptions();
                    subGenre2_dropdown.AddOptions(adventure_subGenre_Selection);

                    break;

                case "Rhythm":
                    subGenre2_dropdown.ClearOptions();
                    subGenre2_dropdown.AddOptions(rhythm_subGenre_Selection);

                    break;

                case "Puzzle":
                    subGenre2_dropdown.ClearOptions();
                    subGenre2_dropdown.AddOptions(puzzle_subGenre_Selection);

                    break;

                case "RPG":
                    subGenre2_dropdown.ClearOptions();
                    subGenre2_dropdown.AddOptions(rpg_subGenre_Selection);

                    break;

                case "Strategy":
                    subGenre2_dropdown.ClearOptions();
                    subGenre2_dropdown.AddOptions(strategy_subGenre_Selection);

                    break;

                case "Simulation":
                    subGenre2_dropdown.ClearOptions();
                    subGenre2_dropdown.AddOptions(sim_subGenre_Selection);

                    break;

                case "Sports":
                    subGenre2_dropdown.ClearOptions();
                    subGenre2_dropdown.AddOptions(sports_subGenre_Selection);

                    break;

                case "Casual":
                    subGenre2_dropdown.ClearOptions();
                    subGenre2_dropdown.AddOptions(casual_subGenre_Selection);

                    break;

                case "Random":
                    
                    break;
            }
        }


    }


    void Toggle2_Functionatlity()
    {
        if (toggle2.isOn)
        {
            Toggle_Two_on();
            
            
            if (dropdown_1.options[dropdown_1.value].text == "Random" && dropdown_2.options[dropdown_2.value].text == "Random")
            {
                subGenre1.SetActive(false);
                subGenre2.SetActive(false);
            }

            else if(dropdown_1.options[dropdown_1.value].text == "Random")
            {
                subGenre1.SetActive(false);
            }

            else if (dropdown_2.options[dropdown_2.value].text == "Random")
            {
                subGenre2.SetActive(false);
            }

            else
            {
                subGenre1.SetActive(true);
                subGenre2.SetActive(true);
                Subgenre1_Input_Options();
                Subgenre2_Input_Options();
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

    public void Change_Loop_Through()
    {
        loop_through = !loop_through;
    }
}
