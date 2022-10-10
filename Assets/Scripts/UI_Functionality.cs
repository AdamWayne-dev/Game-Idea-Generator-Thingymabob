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
    
    
    [Header("Dropdown Lists")]
    

    [Header("Scripts")]
    [SerializeField] SubGenres subGenres;
    [SerializeField] Themes themes;
    [SerializeField] Mechanics mechanics;

    List<string> genres = new List<string>();

    List<string> action_subGenre_Selection;
    List<string> adventure_subGenre_Selection;
    List<string> rhythm_subGenre_Selection;
    List<string> puzzle_subGenre_Selection;
    List<string> rpg_subGenre_Selection;
    List<string> strategy_subGenre_Selection;
    List<string> sim_subGenre_Selection;
    List<string> sports_subGenre_Selection;
    List<string> casual_subGenre_Selection;

    int genre_selection = 0;
    int subGenre_selection = 0;
    
    void Start()
    {
      Add_Genres();

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
    }
    
    void Update()
    {
        
    }
    
    
}
