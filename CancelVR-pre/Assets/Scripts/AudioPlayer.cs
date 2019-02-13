using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class AudioPlayer : MonoBehaviour {

    public AudioClip otherClip;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GlobalVariables.TimeToactivate == true){

            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = otherClip;
            audio.Play();
        }


    }
}
