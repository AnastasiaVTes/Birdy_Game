using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class bird_move : MonoBehaviour
{

    enum Direction { UpForward, DownForward, Forward };
    public GameObject flyable;
    public float offset;
    Direction fly_dir;
    //SpriteRenderer bird_gm;
    Vector3 temp;

    void Start()
    {
        flyable = this.gameObject;
        offset = 0.01f;
        //bird_gm = GetComponent<SpriteRenderer>();
        fly_dir = Direction.Forward;
        temp = flyable.GetComponent<Transform>().position;
    }

    //void OnGUI()
    //{
    //    Event e = Event.current;
    //    if (e.isKey && e.type == EventType.KeyUp)
    //    {

    //        fly_dir = Direction.UpForward;
    //    }
    //}
    void Update()
    {
        temp = flyable.GetComponent<Transform>().position;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (fly_dir != Direction.UpForward)
            {
                fly_dir = Direction.UpForward;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (fly_dir != Direction.DownForward)
            {
                fly_dir = Direction.DownForward;
            }
        }
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    if (fly_dir != Direction.Left)
        //    {
        //        fly_dir = Direction.Left;
        //        if (bird_gm.flipX == false)
        //        {
        //            bird_gm.flipX = true;

        //        }
        //        else
        //        {
        //            bird_gm.flipX = false;

        //        }
        //    }
        //}
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (fly_dir != Direction.Forward)
            {
                fly_dir = Direction.Forward;
                //if (bird_gm.flipX == true)
                //    {
                //        bird_gm.flipX = false;
                //    }
                //}
            }
            //if (Input.GetKeyDown(KeyCode.LeftShift))
            //{
            //    //flip sprite renderer by x when bird changes direction on shift
            //    if (bird_gm.flipX == false)
            //    {
            //        bird_gm.flipX = true;

            //    }
            //    else
            //    {
            //        bird_gm.flipX = false;

            //    }
            //}

            switch (fly_dir)
            {
                case Direction.DownForward:
                    Debug.Log("fly down");
                    flyable.GetComponent<Transform>().position = new Vector3(temp.x + offset, temp.y - offset, temp.z);
                    break;
                case Direction.UpForward:
                    Debug.Log("fly up");
                    flyable.GetComponent<Transform>().position = new Vector3(temp.x + offset, temp.y + offset, temp.z);
                    break;
                //case Direction.Left:
                //        tr.position = new Vector3(temp.x - offset, temp.y, temp.z);
                //        break;
                case Direction.Forward:
                    Debug.Log("fly forward " + flyable.name);
                    flyable.GetComponent<Transform>().position = new Vector3(temp.x + offset, temp.y, temp.z);
                    break;
            }

        }
    }
}
