using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubGenres : ScriptableObject
{

    public string[] action_SubGenres = new string[12];
    public string[] adventure_SubGenres = new string[6];
    public string[] puzzle_SubGenres = new string[10];
    public string[] rpg_SubGenres = new string[10];
    public string[] simulation_SubGenres = new string[5];
    public string[] rhythm_SubGenres = new string[4];
    public string[] strategy_SubGenres = new string[12];
    public string[] sports_SubGenres = new string[6];
    public string[] casual_SubGenres = new string[6];



    public string[] Get_Action_Subgenres()
    {
        action_SubGenres[0] = "Random";
        action_SubGenres[1] = "Platform";
        action_SubGenres[2] = "First-Person Shooter";
        action_SubGenres[3] = "Third-Person Shooter";
        action_SubGenres[4] = "Fighting";
        action_SubGenres[5] = "Beat'em up";
        action_SubGenres[6] = "Stealth";
        action_SubGenres[7] = "Surviveal";
        action_SubGenres[8] = "Battle Royale";
        action_SubGenres[9] = "Horror";
        action_SubGenres[10] = "Metroidvania";
        action_SubGenres[11] = "Custom";
        
        return action_SubGenres;
    }
    public string[] Get_Adventure_Subgenres()
    {
        adventure_SubGenres[0] = "Random";
        adventure_SubGenres[1] = "Text Adventure";
        adventure_SubGenres[2] = "Visual Novel";
        adventure_SubGenres[3] = "Interactive Movie";
        adventure_SubGenres[4] = "Real-Time 3D Adventure";
        adventure_SubGenres[5] = "Custom";
        
        return adventure_SubGenres;
    }

    public string[] Get_Puzzle_Subgenres()
    {
        puzzle_SubGenres[0] = "Random";
        puzzle_SubGenres[1] = "Breakout Clone";
        puzzle_SubGenres[2] = "Logical";
        puzzle_SubGenres[3] = "Trial and Error";
        puzzle_SubGenres[4] = "Hidden Object";
        puzzle_SubGenres[5] = "Reveal the picture";
        puzzle_SubGenres[6] = "Tile-Matching";
        puzzle_SubGenres[7] = "Traditional";
        puzzle_SubGenres[8] = "Puzzle-Platform";
        puzzle_SubGenres[9] = "Custom";

        return puzzle_SubGenres;
    }

    public string[] Get_RPG_Subgenres()
    {
        rpg_SubGenres[0] = "Random";
        rpg_SubGenres[1] = "Action RPG";
        rpg_SubGenres[2] = "JRPG";
        rpg_SubGenres[3] = "Roguelike";
        rpg_SubGenres[4] = "Tactical RPG";
        rpg_SubGenres[5] = "Sandbox RPG";
        rpg_SubGenres[6] = "First Person RPG";
        rpg_SubGenres[7] = "Monster Tamer";
        rpg_SubGenres[8] = "Card RPG";
        rpg_SubGenres[9] = "Custom";

        return rpg_SubGenres;
    }

    public string[] Get_Sim_Subgenres()
    {
        simulation_SubGenres[0] = "Random";
        simulation_SubGenres[1] = "Construction and Management";
        simulation_SubGenres[2] = "Life Simulation";
        simulation_SubGenres[3] = "Vehicle Simulation";
        simulation_SubGenres[4] = "Custom";

        return rpg_SubGenres;
    }

    public string[] Get_Rhythm_Subgenres()
    {
        rhythm_SubGenres[0] = "Random";
        rhythm_SubGenres[1] = "Music";
        rhythm_SubGenres[2] = "Dance";
        rhythm_SubGenres[3] = "Custom";

        return rhythm_SubGenres;
    }

    public string[] Get_Strategy_Subgenres()
    {
        strategy_SubGenres[0] = "Random";
        strategy_SubGenres[1] = "4X";
        strategy_SubGenres[2] = "Artillery";
        strategy_SubGenres[3] = "Auto Battler";
        strategy_SubGenres[4] = "Real-time Strategy";
        strategy_SubGenres[5] = "Real-time Tactics";
        strategy_SubGenres[6] = "Tower Defense";
        strategy_SubGenres[7] = "Turn-based Strategy";
        strategy_SubGenres[8] = "Turn-based Tactics";
        strategy_SubGenres[9] = "Wargame";
        strategy_SubGenres[10] = "Grand Strategy Wargame";
        strategy_SubGenres[11] = "Custom";

        return strategy_SubGenres;
    }

    public string[] Get_Sports_Subgenres()
    {
        sports_SubGenres[0] = "Random";
        sports_SubGenres[1] = "Racing";
        sports_SubGenres[2] = "Sports Game";
        sports_SubGenres[3] = "Competitive";
        sports_SubGenres[4] = "Sports-based Fighting";
        sports_SubGenres[5] = "Custom";

        return sports_SubGenres;
    }

    public string[] Get_Casual_Subgenres()
    {
        sports_SubGenres[0] = "Random";
        sports_SubGenres[1] = "Idle game";
        sports_SubGenres[2] = "Bejewelled clone";
        sports_SubGenres[3] = "Pet game";
        sports_SubGenres[4] = "Gacha game";
        sports_SubGenres[5] = "Custom";

        return casual_SubGenres;
    }
}
