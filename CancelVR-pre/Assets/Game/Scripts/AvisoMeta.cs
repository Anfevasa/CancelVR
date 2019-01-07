using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvisoMeta : MonoBehaviour {
    public int Meta;
    public Text Aviso;

    public GameObject Score;
    public Scoring ScoringScript;

    // Use this for initialization
    void Start()
    {
        Score = GameObject.Find("Score");
        ScoringScript = Score.GetComponent<Scoring>();
    }

    // Update is called once per frame
    void Update()
    {
        Meta = ScoringScript.limit;
        Aviso.text = "Meta: " + Meta.ToString();

    }
}
