using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour {

    public Text Avisos;

    public int contador;

    public GameObject Controller;
    public InicioNivel InicioScript;
    public Transitions TransitionsScript;
    public Niveles NivelesScript;
    public Reset EsteScript;
    

    public GameObject Timer;
    public Tiempo TiempoScript;

    public GameObject Score;
    public Scoring ScoringScript;

    public CardboardControl cardboard;
    

    void Start () {

        Controller = GameObject.Find("GameController");        
        InicioScript = Controller.GetComponent<InicioNivel>();
        TransitionsScript = Controller.GetComponent<Transitions>();
        NivelesScript = Controller.GetComponent<Niveles>();
        EsteScript = Controller.GetComponent<Reset>();

        Timer = GameObject.Find("Time");
        TiempoScript = Timer.GetComponent<Tiempo>();

        Score = GameObject.Find("Score");
        ScoringScript = Score.GetComponent<Scoring>();

        TransitionsScript.enabled = false;

        contador = 0;
                
    }

    
    void Update()
    {
        if (contador == 1 )
        {
            contador = 2;
            InicioScript.CountDown = 5;
            InicioScript.tiempo = 5f;

            InicioScript.enabled = true;
            EsteScript.enabled = false;    
            
        }
      
        if (Input.GetKey(KeyCode.Mouse0))
        {
       
            contador = contador + 1;
        }
        if (contador == 0)
        {
            Avisos.text = "Usa el imán al costado";
        }
    }


    private void CardboardClick(object sender)
    {
        contador = contador + 1;
    }


}
