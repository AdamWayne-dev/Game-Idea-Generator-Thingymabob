using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnTicket : MonoBehaviour
{
    
    bool ticketExist = false;
    Image image;
    

    private void Start()
    {
        image = GetComponent<Image>();
        
        image.enabled = false;
        
    }
    public void GenerateTicket()
    {
        if (!ticketExist)
        {
            image.enabled = true;
            
            ticketExist = true;
        }
    }
}
