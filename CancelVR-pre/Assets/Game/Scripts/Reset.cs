using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour {


    public GameObject Scorer;
    public GameObject Crono;
    public Scoring scoreController;
    public Tiempo resetTiempo;
    public Button button;

    // Use this for initialization


    void Start () {
        Scorer = GameObject.Find("FPSController");
        scoreController = Scorer.GetComponent<Scoring>();
        Crono = GameObject.Find("Temporizador");
        resetTiempo = Crono.GetComponent<Tiempo>();
        
    }


    void Update()
    {
      
        if (Input.GetMouseButtonDown(1))
        {
            scoreController.score = 0;
            resetTiempo.CountDown = 100;
            resetTiempo.tiempo = 100;
            
        }
          


    }
    
}
