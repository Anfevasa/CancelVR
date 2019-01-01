using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scoring : MonoBehaviour {


    // Use this for initialization
    public int score = 0;
    public int limit = 50;

    public bool Meta = false;

    public Text ScoreText;

    public GameObject Scorer;
    public Niveles NivelesScript;

    public GameObject GameController;
    public Scoring EsteScript;

    public GameObject Timer;
    public Tiempo TiempoScript;

    private void Start()
    {
        GameController = GameObject.Find("GameController");
        NivelesScript = GameController.GetComponent<Niveles>();

        Scorer = GameObject.Find("Score");
        EsteScript = Scorer.GetComponent<Scoring>();

        Timer = GameObject.Find("Time");
        TiempoScript = Timer.GetComponent<Tiempo>();

    }

    void Update()
    {
        if (NivelesScript.nivel == 1)
        {
            limit = 50;
        }
        if (NivelesScript.nivel == 2)
        {
            limit = 100;
        }
        if (NivelesScript.nivel == 3)
        {
            limit = 200;
        }
        

        ScoreText.text = "Score: " + score.ToString();
        if (score == limit)
        {
            Meta = true;
            score = 0;
            TiempoScript.CountDown = 0;
            EsteScript.enabled = false;
        }
        else
        {
            Meta = false;
        }
    }

    public void AddScore(int AddValue)
    {
        score += AddValue;
    }
}
