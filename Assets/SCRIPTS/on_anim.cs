using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on_anim : MonoBehaviour {

	public GameObject Cloud;
    GameObject thePlayer;
    public AudioClip Sound;
	void Start () {
        Cloud = this.gameObject;
        thePlayer = GameObject.Find("Bird_Player");
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        player playerScript = thePlayer.GetComponent<player>();
        if (other.gameObject.tag == "Player")
        {
            Cloud.GetComponentInChildren<ParticleSystem>().Play();
            //Debug.Log("animate cloud touched by player");
            AudioSource.PlayClipAtPoint(Sound, transform.position);
        }

        switch (Cloud.name)
        {
            case "Sad_Cloud":
                playerScript.lives = playerScript.lives - 5;
                break;
            case "Angry_Cloud":
                playerScript.lives = playerScript.lives - 10;
                break;
            case "Happy_Cloud":
                playerScript.lives = playerScript.lives + 5;
                break;
            case "Pink_Cloud":
                playerScript.lives = playerScript.lives + 10;
                break;
            case "Dead_Cloud":
                playerScript.lives = playerScript.lives - playerScript.lives;
                break;
            case "Rainbow_Cloud":
                playerScript.lives = playerScript.lives + 20;
                break;

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}


}
