using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scoring : MonoBehaviour {


    // Use this for initialization
    public int score = 0;

    public Text ScoreText;

    private void Start()
    {

        
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);

        ScoreText.text = score.ToString();

    }

    public void AddScore(int AddValue)
    {
        score += AddValue;
    }
}
