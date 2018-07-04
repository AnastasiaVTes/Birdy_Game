using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_music : MonoBehaviour {
    public GameObject musicPlayer;
    static bool AudioBegin = false;
    void Awake()
    {
        musicPlayer = GameObject.Find("Music");
        if (!AudioBegin)
        {
            musicPlayer.GetComponent<AudioSource>().Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Start" || SceneManager.GetActiveScene().name == "End" || SceneManager.GetActiveScene().name == "Bird_anim")
        {
            musicPlayer.GetComponent<AudioSource>().Stop();
            AudioBegin = false;
        }
    }
}
