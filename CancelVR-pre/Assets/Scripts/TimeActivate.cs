using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeActivate : MonoBehaviour {

    private float timer = 0.0f;
    public int SecondsToActivate=3;
    private float crono;
  
    // Use this for initialization
    void Start () {
        GlobalVariables.seconds = 0;
        crono = 0;
    }
	
	// Update is called once per frame
	void Update () {
        
            timer += Time.deltaTime;
            crono = timer % 60;
            GlobalVariables.seconds = (int)crono;
        
        
        if (GlobalVariables.TimeToactivate==true && GlobalVariables.seconds > SecondsToActivate ) {
            GlobalVariables.activate = true;
            GlobalVariables.seconds = 0;
        }
    }
}
