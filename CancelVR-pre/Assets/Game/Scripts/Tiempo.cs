using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tiempo : MonoBehaviour {
    public float tiempo ;
    public int CountDown;
    public int Speed = 10;

    public bool TimeOut = false;

    public Text Tempo;

    public GameObject GameController;
    public Niveles NivelesScript;
    public Reset ResetScript;

    public GameObject Timer;
    public Tiempo EsteScript;


    private void Start()
    {
        GameController = GameObject.Find("GameController");
        NivelesScript = GameController.GetComponent<Niveles>();
        ResetScript = GameController.GetComponent<Reset>();

        Timer = GameObject.Find("Time");
        EsteScript = Timer.GetComponent<Tiempo>();

    }


    void Update()
    {
        if (CountDown > 0)
        {
            Tiempos();
            TimeOut = false;
        }

        if (CountDown == 0)
        {
            TimeOut = true;
            tiempo = 150f;
            CountDown = 150;
            EsteScript.enabled = false;
        }

    }

    void Tiempos()
    {
        tiempo -= Time.deltaTime;
        CountDown = (int)tiempo;
        Tempo.text = "Time: " + CountDown.ToString();
        //ResetScript.enabled = false;
    }


}
