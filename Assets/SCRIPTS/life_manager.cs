using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class life_manager : MonoBehaviour {

    public GameObject lives_meter; //public just to check
    public Sprite heart_full; ///assign hearts in editor
    public Sprite heart_half;
    public Sprite heart_empty;
    GameObject thePlayer;



	void Start () {
        lives_meter = this.gameObject;
        thePlayer = GameObject.Find("Bird_Player");
        
	}
	
	
	void FixedUpdate () {
        player playerScript = thePlayer.GetComponent<player>();


        switch (playerScript.lives)
        {
            case 0:
                lives_meter.transform.Find("Heart_1").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_2").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_3").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_4").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_5").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_6").GetComponent<Image>().sprite = heart_empty;
                break;
            case 5:
                lives_meter.transform.Find("Heart_1").GetComponent<Image>().sprite = heart_half;
                lives_meter.transform.Find("Heart_2").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_3").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_4").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_5").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_6").GetComponent<Image>().sprite = heart_empty;
                break;
            case 10:
                lives_meter.transform.Find("Heart_1").GetComponent<Image>().sprite = heart_full ;
                lives_meter.transform.Find("Heart_2").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_3").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_4").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_5").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_6").GetComponent<Image>().sprite = heart_empty;
                break;
            case 15:
                lives_meter.transform.Find("Heart_1").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_2").GetComponent<Image>().sprite = heart_half;
                lives_meter.transform.Find("Heart_3").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_4").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_5").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_6").GetComponent<Image>().sprite = heart_empty;
                break;
            case 20:
                lives_meter.transform.Find("Heart_1").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_2").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_3").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_4").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_5").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_6").GetComponent<Image>().sprite = heart_empty;
                break;
            case 25:
                lives_meter.transform.Find("Heart_1").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_2").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_3").GetComponent<Image>().sprite = heart_half;
                lives_meter.transform.Find("Heart_4").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_5").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_6").GetComponent<Image>().sprite = heart_empty;
                break;
            case 30:
                lives_meter.transform.Find("Heart_1").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_2").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_3").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_4").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_5").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_6").GetComponent<Image>().sprite = heart_empty;
                break;
            case 35:
                lives_meter.transform.Find("Heart_1").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_2").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_3").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_4").GetComponent<Image>().sprite = heart_half;
                lives_meter.transform.Find("Heart_5").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_6").GetComponent<Image>().sprite = heart_empty;
                break;
            case 40:
                lives_meter.transform.Find("Heart_1").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_2").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_3").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_4").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_5").GetComponent<Image>().sprite = heart_empty;
                lives_meter.transform.Find("Heart_6").GetComponent<Image>().sprite = heart_empty;
                break;
            case 45:
                lives_meter.transform.Find("Heart_1").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_2").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_3").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_4").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_5").GetComponent<Image>().sprite = heart_half;
                lives_meter.transform.Find("Heart_6").GetComponent<Image>().sprite = heart_empty;
                break;
            case 50:
                lives_meter.transform.Find("Heart_1").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_2").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_3").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_4").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_5").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_6").GetComponent<Image>().sprite = heart_empty;
                break;
            case 55:
                lives_meter.transform.Find("Heart_1").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_2").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_3").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_4").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_5").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_6").GetComponent<Image>().sprite = heart_half;
                break;
            case 60:
                lives_meter.transform.Find("Heart_1").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_2").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_3").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_4").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_5").GetComponent<Image>().sprite = heart_full;
                lives_meter.transform.Find("Heart_6").GetComponent<Image>().sprite = heart_full;
                break;
        }
	}
}
