using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transitions : MonoBehaviour {

    public int Speed = 10;

    public int ScoreParcial;
    public int n;
    public int m;

    public Text ScoreText;
    public Text AvisosText;

    public Transform PlayerTransform;
    public Transform PlaySpaceTransform;
    public Transform PositionN1;
    public Transform PositionN2;
    public Transform PositionN3;

    public GameObject GameController;
    public Niveles NivelesScript;
    public Shooter ShooterScript;
    public Reset ResetScript;
    public Transitions EsteScript;

    public GameObject Timer;
    public Tiempo TiempoScript;

    public GameObject Score;
    public Scoring ScoringScript;

    //public GameObject RestartGO;


    // Use this for initialization
    void Start () {

        GameController = GameObject.Find("GameController");
        NivelesScript = GameController.GetComponent<Niveles>();
        ShooterScript = GameController.GetComponent<Shooter>();
        ResetScript = GameController.GetComponent<Reset>();
        EsteScript = GameController.GetComponent<Transitions>();

        Timer = GameObject.Find("Time");
        TiempoScript = Timer.GetComponent<Tiempo>();

        Score = GameObject.Find("Score");
        ScoringScript = Score.GetComponent<Scoring>();

        //Timer.SetActive(false);
        //Score.SetActive(false);
        n = NivelesScript.nivel;
        m = n + 1;


        NivelesScript.enabled = false;
        ShooterScript.enabled = false;
        TiempoScript.enabled = false;
        ScoringScript.enabled = false;

        

        ResetScript.contador = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (NivelesScript.nivel == 0)
        {
            Transition(PositionN1);
        }
        if (NivelesScript.nivel == 1)
        {
            Transition(PositionN2);
        }
        if (NivelesScript.nivel == 2)
        {
            Transition(PositionN3);
        }

        if (NivelesScript.nivel == 3)
        {
            ResetScript.Avisos.text = "Game Over";
        }

        ScoreParcial = ScoringScript.limit;
        AvisosText.text = " ";
                
    }

    void Transition(Transform Place)
    {
        PlayerTransform.position = Vector3.MoveTowards(PlayerTransform.position, Place.position, Time.deltaTime * Speed);
        PlaySpaceTransform.position = new Vector3(-50, -50, -50);
        ScoreText.text = "Score: " + ScoreParcial.ToString();
        if (PlayerTransform.position == Place.position)
        {
            NivelesScript.nivel = NivelesScript.nivel + 1;
            ResetScript.enabled = true;
            ResetScript.contador = 0;
            //RestartGO.SetActive(true);
            ScoringScript.score = ScoreParcial;
            EsteScript.enabled = false;            
        }
        
    }
}
