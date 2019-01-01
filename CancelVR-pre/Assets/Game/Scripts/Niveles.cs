using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Niveles : MonoBehaviour {

    public int nivel = 0;
  
    public Transform PlaySpace;
    public Transform Player;
 
    public Light Light;

    public GameObject GameController;
    public Reset ResetScript;
    public Shooter ShooterScript;
    public InicioNivel InicioNivelScript;
    public Transitions TransitionsScript;
    public Niveles EsteScript;
    
    public GameObject Time;
    public Tiempo TiempoScript;

    public GameObject Score;
    public Scoring ScoringScript;
    

	// Use this for initialization
	void Start () {


        GameController = GameObject.Find("GameController");
        ResetScript = GameController.GetComponent<Reset>();
        ShooterScript = GameController.GetComponent<Shooter>();
        InicioNivelScript = GameController.GetComponent<InicioNivel>();
        TransitionsScript = GameController.GetComponent<Transitions>();
        EsteScript = GameController.GetComponent<Niveles>();

        InicioNivelScript.enabled = false;
        
        Time = GameObject.Find("Time");
        TiempoScript = Time.GetComponent<Tiempo>();

        Score = GameObject.Find("Score");
        ScoringScript = Score.GetComponent<Scoring>();

        if (nivel == 1)
        {
            ScoringScript.score = 0;
            ScoringScript.limit = 50;

            TiempoScript.tiempo = 150f;
            TiempoScript.CountDown = 150;
        }
        if (nivel == 2)
        {
            ScoringScript.score = 0;
            ScoringScript.limit = 70;

            TiempoScript.tiempo = 12f;
            TiempoScript.CountDown = 12;
        }
        if (nivel == 3)
        {
            ScoringScript.score = 0;
            ScoringScript.limit = 100;

            TiempoScript.tiempo = 15f;
            TiempoScript.CountDown = 15;
        }



        //Score.SetActive(true);
        //Time.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        
        if (ScoringScript.Meta == true || TiempoScript.TimeOut == true)
        {
            TransitionsScript.enabled = true;
            TiempoScript.TimeOut = false;
            ScoringScript.Meta = false;
            TiempoScript.Tempo.text = "Time: 150";
            ScoringScript.ScoreText.text = "Score: 0";
            EsteScript.enabled = false;                  

        }

        else
        {

            ShooterScript.enabled = true;
            ScoringScript.enabled = true;
            TiempoScript.enabled = true;

        }
        
       

    }


}
