using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvisoNivel : MonoBehaviour {

    public int Level;
    public Text Aviso;

    public GameObject GameController;
    public Niveles NivelesScript;

	// Use this for initialization
	void Start () {
        GameController = GameObject.Find("GameController");
        NivelesScript = GameController.GetComponent<Niveles>();
	}
	
	// Update is called once per frame
	void Update () {
        Level = NivelesScript.nivel;
        Aviso.text = "Nivel: " + Level.ToString();
	}
}
