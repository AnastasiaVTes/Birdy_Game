using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    public int lives; //10 = 1 heart, 5 = 1/2 heart
    public int score;

    public GameObject death_m;
	void Start () {
        lives = 10; //1 starting heart
        
        //death_m = GameObject.FindGameObjectWithTag("death_m");
        //ob.SetActive(false);
	}
	
	
	void Update () {
        if (lives == 0) 
        {
            death_m.SetActive(true);
            //StartCoroutine(MyEndTimer());
        }
	}
    //IEnumerator MyEndTimer()
    //{
    //    death_m.SetActive(true);
    //    yield return 50;    //Wait one frame
    //    SceneManager.LoadScene("End");
    //}


}
