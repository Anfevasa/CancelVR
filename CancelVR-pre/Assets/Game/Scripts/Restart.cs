using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour {

    public Transform Position1;
    public Transform Position2;
    public Transform Position3;


    public GameObject GameController;
    public Niveles NivelesScript;

    

     void Start()
    {
        GameController = GameObject.Find("GameController");
        NivelesScript = GameController.GetComponent<Niveles>();
        
    }

     void Update()
    {
        if (NivelesScript.nivel == 1)
        {
            gameObject.transform.position = Position1.position;
        }
        if (NivelesScript.nivel == 2)
        {
            gameObject.transform.position = Position2.position;
        }
        if (NivelesScript.nivel == 3)
        {
            gameObject.transform.position = Position3.position;
        }
    }
}
