using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_click_handler : MonoBehaviour {

    public void click_play()
    {
        SceneManager.LoadScene("Start");
        
    }
    public void click_about()
    {
        //add some about? screen
    }
    public void start_play()
    {
        SceneManager.LoadScene("Bird_anim");
        
    }
    public void start_end()
    {
        SceneManager.LoadScene("End");

    }
    public void return_menu()
    {
        SceneManager.LoadScene("MainMenu");

    }
    public void click_scores()
    {
        SceneManager.LoadScene("Highscores");

    }
    public void click_exit() 
    {
        Application.Quit();
        
    }
}
