using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InicioNivel : MonoBehaviour {

    public float tiempo = 3.0f;    
    public int CountDown;

    public Text Tempo;
    public Light lightVariable;

    public GameObject Controller;
    public Niveles NivelesScript;
    public Reset ResetScript;
    public InicioNivel EsteScript;

    public Transform PlaySpaceTransform;
    public Transform PlayerTransform;

    void Start()
    {        
                
        Controller = GameObject.Find("GameController");
        NivelesScript = Controller.GetComponent<Niveles>();
        ResetScript = Controller.GetComponent<Reset>();
        EsteScript = Controller.GetComponent<InicioNivel>();
       
        ResetScript.enabled = false;
        tiempo = 3.0f;
        

    }

    void Update()
    {

        if (CountDown > 0)
        {
            CuentaRegresiva();
        }

        if (CountDown == 0)
        {
            Tempo.text = " ";
            NivelesScript.enabled = true;
            EsteScript.enabled = false;
        }

    }

    void CuentaRegresiva()
    {
        tiempo -= Time.deltaTime;
        CountDown = (int)tiempo;
        Tempo.text = CountDown.ToString();
        PlaySpaceTransform.position = PlayerTransform.position;

        if (NivelesScript.nivel == 1)
        {
            lightVariable.intensity = 0f;
        }
        if (NivelesScript.nivel == 2)
        {
            lightVariable.intensity = 0.8f;
        }
        if (NivelesScript.nivel == 3)
        {
            lightVariable.intensity = 0.8f;
        }

    }
}
