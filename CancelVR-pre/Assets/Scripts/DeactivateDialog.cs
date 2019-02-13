using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateDialog : MonoBehaviour {

    public GameObject myObject;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (GlobalVariables.activate) {
            myObject.SetActive(false);
        }
	}
}
