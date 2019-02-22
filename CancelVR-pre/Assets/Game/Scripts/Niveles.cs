using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Niveles : MonoBehaviour {

    public int nivel = 2;

    public Transform PlaySpace;
    public Transform Player;
    public Transform PositionL2;
    public Transform PositionL3;

    public Light Light;

	// Use this for initialization
	void Start () {
        if (nivel == 2)
        {
            PlaySpace.position = PositionL2.position;
            Player.position = PositionL2.position;
            Light.intensity = 0.8f;
        }
        if (nivel == 3)
        {
            PlaySpace.position = PositionL3.position;
            Player.position = PositionL3.position;
            Light.intensity = 1.2f;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
