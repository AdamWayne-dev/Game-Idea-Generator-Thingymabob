using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance { get; private set; }
    int trashedTickets = 0;
    
    void Awake()
    {
        instance = this;
    }

    
    
    public void LoadCustomise()
    {
        SceneManager.LoadScene("Customise");
    }

    public void LoadRoom()
    {
        SceneManager.LoadScene("Room");
    }

    public void LoadTicket()
    {
        SceneManager.LoadScene("Ticket");
    }

    public void LoadBin()
    {
        SceneManager.LoadScene("Bin");
    }

    public void LoadFilingCab()
    {
        SceneManager.LoadScene("Filing Cabinet");
    }

    public void SaveTicket()
    {
        //  Add code for saving a ticket to the filing system 
    }

    public void TrashTicket()
    {
        trashedTickets++;
        Debug.Log("Number of tickets in trash: " + trashedTickets);
         //  Add code for sending the ticket to the bin 
    }

    public void EmptyBin()
    {
        //  Add code for empty bin
    }
}
