using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetActivate : MonoBehaviour
{

    private float timer = 0.0f;
    public int SecondsToActivate = 3;
    private int seconds;
    // Use this for initialization
    void Start()
    {
        seconds = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        float crono = timer % 60;
        seconds = (int)crono;
        if (GlobalVariables.TimeToactivate == true && seconds > SecondsToActivate)
        {
            GlobalVariables.activate = true;
            seconds = 0;
        }
    }
}
