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
   
    [Header("Scripts")]
    [SerializeField] SubGenres subGenres;
    [SerializeField] Themes themes;
    [SerializeField] Mechanics mechanics;

    [Header("Text_Fields")]
    [SerializeField] TMP_Text genre1_Text;
    [SerializeField] TMP_Text genre2_Text;
    [SerializeField] TMP_Text subGenre1_Text;
    [SerializeField] TMP_Text subGenre2_Text;
    [SerializeField] TMP_Text theme_Text;
    [SerializeField] TMP_Text mechanics_Text;

    [Header("Objects")]
    [SerializeField] GameObject Genre1;
    [SerializeField] GameObject Genre2;
    [SerializeField] GameObject subgenre1;
    [SerializeField] GameObject subgenre2;
    [SerializeField] GameObject themeObject;
    [SerializeField] GameObject mechanicObject;

    List<string> genres = new List<string>();
    List<string> theme_List = new List<string>();
    List<string> mechanics_List = new List<string>();

    List<string> action_subGenre_Selection;
    List<string> adventure_subGenre_Selection;
    List<string> rhythm_subGenre_Selection;
    List<string> puzzle_subGenre_Selection;
    List<string> rpg_subGenre_Selection;
    List<string> strategy_subGenre_Selection;
    List<string> sim_subGenre_Selection;
    List<string> sports_subGenre_Selection;
    List<string> casual_subGenre_Selection;

    int genre_Selection = 0;
    int subGenre_Selection = 0;
    int theme_Selection = 0;
    int mechanic_Selection = 0;

    string genre1_Choice;
    string genre2_Choice;
    string subGenre1_Choice;
    string subGenre2_Choice;
    string theme_Choice;
    string mechanic_Choice;
    
    void Start()
    {
        Add_Genres();
        Toggle_1_On();
        Set_SubGenres();
        setThemes_and_Mechanics();
        Hide_Objects();
    }

    private void Hide_Objects()
    {
        Genre1.SetActive(false);
        Genre2.SetActive(false);
        subgenre1.SetActive(false);
        subgenre2.SetActive(false);
        themeObject.SetActive(false);
        mechanicObject.SetActive(false);
    }

    private void setThemes_and_Mechanics() // Retrieve themes and mechanics information from relevant scripts.
    {
        theme_List = themes.Get_Themes();
        mechanics_List = mechanics.Get_Mechanics();
    }
    private void Set_SubGenres()
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
    } // Retrieves Subgenre information from the public methods in the 'Subgenre' script.

    public void Add_Genres()
    {
        genres.Add("Action");
        genres.Add("Adventure");
        genres.Add("Rhythm");
        genres.Add("Puzzle");
        genres.Add("RPG");
        genres.Add("Strategy");
        genres.Add("Simulation");
        genres.Add("Sports");
        genres.Add("Casual");
    } // Adds genre information to the genre list
    

    public void Generate_Random_Game()
    {
        if (toggle1.isOn)
        {
            Genre1.SetActive(true);
            subgenre1.SetActive(true);
            themeObject.SetActive(true);
            mechanicObject.SetActive(true);
            Genre2.SetActive(false);
            subgenre2.SetActive(false);

            Toggle1_Choices();
            Set_Toggle1_Ticket_Text();    
        }

        else if (toggle2.isOn)
        {
            Genre1.SetActive(true);
            Genre2.SetActive(true);
            subgenre1.SetActive(true);
            subgenre2.SetActive(true);
            themeObject.SetActive(true);
            mechanicObject.SetActive(true);

            Toggle2_Choices();
            Set_Toggle2_Ticket_Text();
        }
    }

    private void Toggle1_Choices()
    {
        Genre_1_Generation();
        theme_Selection = Random.Range(0, theme_List.Count);
        theme_Choice = theme_List[theme_Selection];

        mechanic_Selection = Random.Range(0, mechanics_List.Count);
        mechanic_Choice = mechanics_List[mechanic_Selection];
    }

    private void Toggle2_Choices()
    {
        Genre_1_Generation();
        Genre_2_Generation();
        theme_Selection = Random.Range(0, theme_List.Count);
        theme_Choice = theme_List[theme_Selection];

        mechanic_Selection = Random.Range(0, mechanics_List.Count);
        mechanic_Choice = mechanics_List[mechanic_Selection];
    }

    private void Genre_1_Generation()
    {
        genre_Selection = Random.Range(0, genres.Count);
        genre1_Choice = genres[genre_Selection];

        switch (genre1_Choice)
        {
            case "Action":
                subGenre_Selection = Random.Range(0, action_subGenre_Selection.Count);
                subGenre1_Choice = action_subGenre_Selection[subGenre_Selection];
                break;

            case "Adventure":
                subGenre_Selection = Random.Range(0, adventure_subGenre_Selection.Count);
                subGenre1_Choice = adventure_subGenre_Selection[subGenre_Selection];
                break;

            case "Rhythm":
                subGenre_Selection = Random.Range(0, rhythm_subGenre_Selection.Count);
                subGenre1_Choice = rhythm_subGenre_Selection[subGenre_Selection];
                break;

            case "Puzzle":
                subGenre_Selection = Random.Range(0, puzzle_subGenre_Selection.Count);
                subGenre1_Choice = puzzle_subGenre_Selection[subGenre_Selection];
                break;

            case "RPG":
                subGenre_Selection = Random.Range(0, rpg_subGenre_Selection.Count);
                subGenre1_Choice = rpg_subGenre_Selection[subGenre_Selection];
                break;

            case "Strategy":
                subGenre_Selection = Random.Range(0, strategy_subGenre_Selection.Count);
                subGenre1_Choice = strategy_subGenre_Selection[subGenre_Selection];
                break;

            case "Simulation":
                subGenre_Selection = Random.Range(0, sim_subGenre_Selection.Count);
                subGenre1_Choice = sim_subGenre_Selection[subGenre_Selection];
                break;

            case "Sports":
                subGenre_Selection = Random.Range(0, sports_subGenre_Selection.Count);
                subGenre1_Choice = sports_subGenre_Selection[subGenre_Selection];
                break;

            case "Casual":
                subGenre_Selection = Random.Range(0, casual_subGenre_Selection.Count);
                subGenre1_Choice = casual_subGenre_Selection[subGenre_Selection];
                break;
        }
    }

    private void Genre_2_Generation()
    {
        genre_Selection = Random.Range(0, genres.Count);
        genre1_Choice = genres[genre_Selection];
       
        switch (genre1_Choice)
        {
            case "Action":
                subGenre_Selection = Random.Range(0, action_subGenre_Selection.Count);
                subGenre1_Choice = action_subGenre_Selection[subGenre_Selection];
                
                break;

            case "Adventure":
                subGenre_Selection = Random.Range(0, adventure_subGenre_Selection.Count);
                subGenre1_Choice = adventure_subGenre_Selection[subGenre_Selection];
                
                break;

            case "Rhythm":
                subGenre_Selection = Random.Range(0, rhythm_subGenre_Selection.Count);
                subGenre1_Choice = rhythm_subGenre_Selection[subGenre_Selection];
                
                break;

            case "Puzzle":
                subGenre_Selection = Random.Range(0, puzzle_subGenre_Selection.Count);
                subGenre1_Choice = puzzle_subGenre_Selection[subGenre_Selection];

                break;

            case "RPG":
                subGenre_Selection = Random.Range(0, rpg_subGenre_Selection.Count);
                subGenre1_Choice = rpg_subGenre_Selection[subGenre_Selection];
               
                break;

            case "Strategy":
                subGenre_Selection = Random.Range(0, strategy_subGenre_Selection.Count);
                subGenre1_Choice = strategy_subGenre_Selection[subGenre_Selection];
                
                break;

            case "Simulation":
                subGenre_Selection = Random.Range(0, sim_subGenre_Selection.Count);
                subGenre1_Choice = sim_subGenre_Selection[subGenre_Selection];

                break;

            case "Sports":
                subGenre_Selection = Random.Range(0, sports_subGenre_Selection.Count);
                subGenre1_Choice = sports_subGenre_Selection[subGenre_Selection];
                
                break;

            case "Casual":
                subGenre_Selection = Random.Range(0, casual_subGenre_Selection.Count);
                subGenre1_Choice = casual_subGenre_Selection[subGenre_Selection];

                break;
        }

        
        genre_Selection = Random.Range(0, genres.Count);
        genre2_Choice = genres[genre_Selection];
        while(genre2_Choice == genre1_Choice)
        {
            genre_Selection = Random.Range(0, genres.Count);
            genre2_Choice = genres[genre_Selection];
        }
        switch (genre2_Choice)
        {
            case "Action":
                subGenre_Selection = Random.Range(0, action_subGenre_Selection.Count);
                subGenre2_Choice = action_subGenre_Selection[subGenre_Selection];
                break;

            case "Adventure":               
                subGenre_Selection = Random.Range(0, adventure_subGenre_Selection.Count);
                subGenre2_Choice = adventure_subGenre_Selection[subGenre_Selection];
                break;

            case "Rhythm":                
                subGenre_Selection = Random.Range(0, rhythm_subGenre_Selection.Count);
                subGenre2_Choice = rhythm_subGenre_Selection[subGenre_Selection];
                break;

            case "Puzzle":               
                subGenre_Selection = Random.Range(0, puzzle_subGenre_Selection.Count);
                subGenre2_Choice = puzzle_subGenre_Selection[subGenre_Selection];
                break;

            case "RPG":               
                subGenre_Selection = Random.Range(0, rpg_subGenre_Selection.Count);
                subGenre2_Choice = rpg_subGenre_Selection[subGenre_Selection];
                break;

            case "Strategy":               
                subGenre_Selection = Random.Range(0, strategy_subGenre_Selection.Count);
                subGenre2_Choice = strategy_subGenre_Selection[subGenre_Selection];
                break;

            case "Simulation":               
                subGenre_Selection = Random.Range(0, sim_subGenre_Selection.Count);
                subGenre2_Choice = sim_subGenre_Selection[subGenre_Selection];
                break;

            case "Sports":                
                subGenre_Selection = Random.Range(0, sports_subGenre_Selection.Count);
                subGenre2_Choice = sports_subGenre_Selection[subGenre_Selection];
                break;

            case "Casual":                
                subGenre_Selection = Random.Range(0, casual_subGenre_Selection.Count);
                subGenre2_Choice = casual_subGenre_Selection[subGenre_Selection];
                break;
        }
    }

    public void Toggle_1_On() // Sets toggle 1 to on.
    {
        toggle1.isOn = true;
    }

    public void Set_Toggle1_Ticket_Text()
    {
        genre1_Text.text = genre1_Choice;
        subGenre1_Text.text = subGenre1_Choice;
        theme_Text.text = theme_Choice;
        mechanics_Text.text = mechanic_Choice;
    }
    public void Set_Toggle2_Ticket_Text()
    {
        genre1_Text.text = genre1_Choice;
        genre2_Text.text = genre2_Choice;
        subGenre1_Text.text = subGenre1_Choice;
        subGenre2_Text.text = subGenre2_Choice;
        theme_Text.text = theme_Choice;
        mechanics_Text.text = mechanic_Choice;
    }
}
