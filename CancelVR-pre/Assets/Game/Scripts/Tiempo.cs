using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tiempo : MonoBehaviour {

	public float tiempo = 0.0f;
    public Text Tempo;
    public GameObject Manager;
    private Shooter shooter;
    private int cont = 0;
    public GameObject Reset;
    public int CountDown = 1000;




    private void Start()
    {
        //  Invoke("timepdate", 1f);
        Manager = GameObject.Find("FPSController");
        shooter = Manager.GetComponent<Shooter>();


    }
    // Update is called once per frame
    void Update () {
        if (CountDown > 0)
        {
            tiempos();
        }

        if (CountDown == 0 )
        {
            Reset.SetActive(true);
            shooter.enabled = false;

            //while (CountDown == 0)
            //{
            //    cont = cont + 1;
            //}
        }
        
    }

    void tiempos()
    {
        tiempo -= Time.deltaTime;
        CountDown = (int)tiempo;
    Tempo.text = CountDown.ToString();
        //Debug.Log(CountDown);
        shooter.enabled = true;
        Reset.SetActive(false);
    }
    
}
