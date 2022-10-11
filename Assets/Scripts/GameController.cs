using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance { get; private set; }
    
    
    void Awake()
    {
        instance = this;
    }

    

    public void LoadRoom()
    {
        SceneManager.LoadScene("Room");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    

    

    

    

   

   
}
