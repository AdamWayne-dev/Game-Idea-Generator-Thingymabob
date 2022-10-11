using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SubGenres : MonoBehaviour
{
    
    List<string> action_SubGenres = new List<string>();
    List<string> adventure_SubGenres = new List<string>();
    List<string> puzzle_SubGenres = new List<string>();
    List<string> rpg_SubGenres = new List<string>();
    List<string> simulation_SubGenres = new List<string>();
    List<string> rhythm_SubGenres = new List<string>();
    List<string> strategy_SubGenres = new List<string>();
    List<string> sports_SubGenres = new List<string>();
    List<string> casual_SubGenres = new List<string>();

    private void Start()
    {
        Add_Action_Subgenres();
        Add_Adventure_Subgenres();
        Add_Puzzle_Subgenres();
        Add_RPG_Subgenres();
        Add_Rhythm_Subgenres();
        Add_Strategy_Subgenres();
        Add_Sim_Subgenres();
        Add_Sports_Subgenres();
        Add_Casual_Subgenres();
    }

    public void Add_Action_Subgenres()
    {
        action_SubGenres.Add("Platform");
        action_SubGenres.Add("First-Person Shooter");
        action_SubGenres.Add("Third-Person Shooter");
        action_SubGenres.Add("Fighting");
        action_SubGenres.Add("Beat'em up");
        action_SubGenres.Add("Stealth");
        action_SubGenres.Add("Survival");
        action_SubGenres.Add("Battle Royale");
        action_SubGenres.Add("Horror");
        action_SubGenres.Add("Metroidvania");
        
    }

    public List<string> Get_Action_Subgenres()
    {
        return action_SubGenres;
    }
    public void Add_Adventure_Subgenres()
    {
        adventure_SubGenres.Add("Text Adventure");
        adventure_SubGenres.Add("Visual Novel");
        adventure_SubGenres.Add("Interactive Movie");
        adventure_SubGenres.Add("Real-Time 3D Adventure");
        adventure_SubGenres.Add("Classic Adventure");
    }
    public List<string> Get_Adventure_Subgenres()
    {
        return adventure_SubGenres;
    }

    public void Add_Puzzle_Subgenres()
    {
        puzzle_SubGenres.Add("Breakout Clone");
        puzzle_SubGenres.Add("Logical");
        puzzle_SubGenres.Add("Trial and error");
        puzzle_SubGenres.Add("Hidden Object");
        puzzle_SubGenres.Add("Reveal the Picture");
        puzzle_SubGenres.Add("Tile-Matching");
        puzzle_SubGenres.Add("Traditional");
        puzzle_SubGenres.Add("Puzzle-Platform");
    }
    public List<string> Get_Puzzle_Subgenres()
    {
        return puzzle_SubGenres;
    }

    public void Add_RPG_Subgenres()
    {
        rpg_SubGenres.Add("Action RPG");
        rpg_SubGenres.Add("JRPG");
        rpg_SubGenres.Add("RogueLike");
        rpg_SubGenres.Add("Tactical RPG");
        rpg_SubGenres.Add("Sandbox RPG");
        rpg_SubGenres.Add("First Person RPG");
        rpg_SubGenres.Add("Monster Tamer");
        rpg_SubGenres.Add("Card RPG");
    }
    public List<string> Get_RPG_Subgenres()
    {
        return rpg_SubGenres;
    }

    public void Add_Sim_Subgenres()
    {
        simulation_SubGenres.Add("Construction");
        simulation_SubGenres.Add("Life Simulation");
        simulation_SubGenres.Add("Vehicle Simulation");
    }

    public List<string> Get_Sim_Subgenres()
    {
        return simulation_SubGenres;
    }

    public void Add_Rhythm_Subgenres()
    {
        rhythm_SubGenres.Add("Music");
        rhythm_SubGenres.Add("Dance");
    }

    public List<string> Get_Rhythm_Subgenres()
    {
        return rhythm_SubGenres;
    }

    public void Add_Strategy_Subgenres()
    {
        strategy_SubGenres.Add("4X");
        strategy_SubGenres.Add("Artillery");
        strategy_SubGenres.Add("Auto Battler");
        strategy_SubGenres.Add("Real-time Strategy");
        strategy_SubGenres.Add("Real-time Tactics");
        strategy_SubGenres.Add("Tower Defense");
        strategy_SubGenres.Add("Turn-based Strategy");
        strategy_SubGenres.Add("Turn-based Tactics");
        strategy_SubGenres.Add("Wargame");
        strategy_SubGenres.Add("Grand Strategy Wargame");
    }
    public List<string> Get_Strategy_Subgenres()
    {
        return strategy_SubGenres;
    }

    public void Add_Sports_Subgenres()
    {
        sports_SubGenres.Add("Racing");
        sports_SubGenres.Add("Sports Game");
        sports_SubGenres.Add("Competitive");
        sports_SubGenres.Add("Sports-based Fighting");
    }

    public List<string> Get_Sports_Subgenres()
    {   
        return sports_SubGenres;
    }

    public void Add_Casual_Subgenres()
    {
        casual_SubGenres.Add("Idle game");
        casual_SubGenres.Add("Bejewelled clone");
        casual_SubGenres.Add("Pet game");
        casual_SubGenres.Add("Gacha game");
    }

    public List<string> Get_Casual_Subgenres()
    {
        return casual_SubGenres;
    }

   
}
