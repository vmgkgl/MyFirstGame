using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnime : MonoBehaviour
{
    public string rightAnime = "";
    public string leftAnime = "";

    string nowMode = "";

    void Update()
    {
        if (Input.GetKey("right"))
        {
            nowMode = rightAnime;
        }
        if (Input.GetKey("left"))
        {
            nowMode = leftAnime;
        }
    }
    void FixedUpdate()
    {
        this.GetComponent<Animator>().Play(nowMode);
    }
}
