using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaMagneto : MonoBehaviour {

    private void CardboardClick(object sender)
    {
        //ChangeObjectColor("SphereClick");

        //TextMesh textMesh = GameObject.Find("SphereClick/Counter").GetComponent<TextMesh>();
       // int increment = int.Parse(textMesh.text) + 1;
        //textMesh.text = increment.ToString();

        // With the cardboard object, we can grab information from various controls
        // If the raycast doesn't find anything then the focused object will be null
      //  string name = cardboard.gaze.IsHeld() ? cardboard.gaze.Object().name : "nothing";
      //  float count = cardboard.gaze.SecondsHeld();
        Debug.Log("pressed");

        // If you need more raycast data from cardboard.gaze, the RaycastHit is exposed as gaze.Hit()
    }


}
