using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Themes : MonoBehaviour
{
    List<string> themes = new List<string>();
    void Start()
    {
        Add_Themes();
    }

    private void Add_Themes()
    {
        themes.Add("Alchemy");
        themes.Add("Aliens");
        themes.Add("Ancient");
        themes.Add("Animals");
        themes.Add("Art");
        themes.Add("Assassination");
        themes.Add("Aviation");
        themes.Add("Books");
        themes.Add("Building");
        themes.Add("Cars");
        themes.Add("Castles");
        themes.Add("Circus");
        themes.Add("Cities");
        themes.Add("Civilization");
        themes.Add("Climate");
        themes.Add("Comic Book");
        themes.Add("Conspiracy");
        themes.Add("Cooking");
        themes.Add("Creativity");
        themes.Add("Crime");
        themes.Add("Cryptography");
        themes.Add("Cycling");
        themes.Add("Death");
        themes.Add("Detective");
        themes.Add("Dinosaurs");
        themes.Add("Dragons");
        themes.Add("Dreams");
        themes.Add("Dungeons");
        themes.Add("Economy");
        themes.Add("Education");
        themes.Add("Electronic");
        themes.Add("Enviromental");
        themes.Add("Escape");
        themes.Add("Espionage");
        themes.Add("Evolution");
        themes.Add("Exploration");
        themes.Add("Fantasy");
        themes.Add("Farming");
        themes.Add("Fashion");
        themes.Add("Food");
        themes.Add("Fire");
        themes.Add("Flight");
        themes.Add("Flowers");
        themes.Add("Gambling");
        themes.Add("Gardening");
        themes.Add("Geology");
        themes.Add("History");
        themes.Add("Halloween");
        themes.Add("Humour");
        themes.Add("Hunting");
        themes.Add("Industry");
        themes.Add("Insects");
        themes.Add("Knowledge");
        themes.Add("Language");
        themes.Add("Lovecraft");
        themes.Add("Mafia");
        themes.Add("Magic");
        themes.Add("Manufacturing");
        themes.Add("Math");
        themes.Add("Mature");
        themes.Add("Maze");
        themes.Add("Mechanical");
        themes.Add("Medical");
        themes.Add("Medieval");
        themes.Add("Mercantile");
        themes.Add("Mining");
        themes.Add("Money");
        themes.Add("Monsters");
        themes.Add("Movies");
        themes.Add("Murder");
        themes.Add("Music");
        themes.Add("Mystery");
        themes.Add("Mythology");
        themes.Add("Nature");
        themes.Add("Nautical");
        themes.Add("Negotiation");
        themes.Add("Ninjas");
        themes.Add("Numbers");
        themes.Add("Ocean");
        themes.Add("Painting");
        themes.Add("Pirates");
        themes.Add("Planets");
        themes.Add("Political");
        themes.Add("Post Apocalyptic");
        themes.Add("Prison");
        themes.Add("Religion");
        themes.Add("Renaissance");
        themes.Add("Robots");
        themes.Add("Royalty");
        themes.Add("Samurai");
        themes.Add("Science");
        themes.Add("Sci-fi");
        themes.Add("Shapes");
        themes.Add("Ships");
        themes.Add("Space");
        themes.Add("Steampunk");
        themes.Add("Submarines");
        themes.Add("Superheroes");
        themes.Add("Symbols");
        themes.Add("Time Travel");
        themes.Add("Trains");
        themes.Add("Transportation");
        themes.Add("Travel");
        themes.Add("Treasure");
        themes.Add("Trees");
        themes.Add("Trivia");
        themes.Add("Tropical");
        themes.Add("Underwater");
        themes.Add("Vampires");
        themes.Add("Victorian");
        themes.Add("Vikings");
        themes.Add("War");
        themes.Add("Wild West");
        themes.Add("Winter");
        themes.Add("Words");
        themes.Add("Zombies");
    }

    public List<string> Get_Themes()
    {
        return themes;
    }
}
