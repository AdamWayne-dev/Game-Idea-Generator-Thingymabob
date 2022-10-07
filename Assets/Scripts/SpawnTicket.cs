using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnTicket : MonoBehaviour
{
    
    bool ticketExist = false;
    Image image;
    Button button;

    private void Start()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        image.enabled = false;
        button.enabled = false;
    }
    public void GenerateTicket()
    {
        if (!ticketExist)
        {
            image.enabled = true;
            button.enabled = true;
            ticketExist = true;
        }
    }
}
