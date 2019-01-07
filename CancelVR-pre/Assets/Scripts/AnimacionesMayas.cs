using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionesMayas : MonoBehaviour {

    public Transform PlayerTransform;
    public Transform Inicio;

    public Animator Animation;
    public Animator SecuenciaTumba;
    // Use this for initialization
    void Start ()
    {
	
        
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerTransform.position != Inicio.position)
        {
            Animation.enabled = (true);
            SecuenciaTumba.enabled = (true);
        }
	}
}
