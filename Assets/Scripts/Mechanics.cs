using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanics : MonoBehaviour
{
    // Start is called before the first frame update
    List<string> mechanics = new List<string>();
    void Start()
    {
        Add_Themes();
    }

    private void Add_Themes()
    {
        mechanics.Add("Pushing");
        mechanics.Add("Pulling");
        mechanics.Add("Grappling");
        mechanics.Add("Spinning");
        mechanics.Add("Breaking");
        mechanics.Add("Building");
        mechanics.Add("Sliding");
        mechanics.Add("Cards");
        mechanics.Add("Rolling");
        mechanics.Add("Defending");
        mechanics.Add("Healing");
        mechanics.Add("Absorbing");
        mechanics.Add("Taking");
        mechanics.Add("Placing");
        mechanics.Add("Breeding");
        mechanics.Add("Nurturing");
        mechanics.Add("Collecting");
        mechanics.Add("Spending");
        mechanics.Add("Hunting");
        mechanics.Add("Searching");
        mechanics.Add("Digging");
        mechanics.Add("Shaking");
        mechanics.Add("Matching");
        mechanics.Add("Reducing");
        mechanics.Add("Enhancing");
        mechanics.Add("Growing");
        mechanics.Add("Shrinking");
        mechanics.Add("Feeding");
        mechanics.Add("Turning");
        mechanics.Add("Colouring");
        mechanics.Add("Lighting");
        mechanics.Add("Burning");
        mechanics.Add("Weakening");
        mechanics.Add("Buying");
        mechanics.Add("Selling");
        mechanics.Add("Lifting");
        mechanics.Add("Combining");
        mechanics.Add("Following");
        mechanics.Add("Copying");
        mechanics.Add("Drawing");
        
    }
}
