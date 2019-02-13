using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeImage : MonoBehaviour {
    private float timer = 0.0f;
    private float seconds;
    private int secondscounter;
    public Image myimage;
    public Sprite Image1;
    public Sprite Image2;
    public Sprite Image3;
    // Use this for initialization
    void Start () {
        secondscounter = 0;
        seconds = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (secondscounter == 0)
        {
        myimage.sprite = Image1;
        }
        else if (secondscounter == 3) {
        myimage.sprite = Image2;
        }
        else if (secondscounter == 6) {
        myimage.sprite = Image3;
        }
        else if (secondscounter == 9)
        {
            SceneManager.LoadScene("MainVR2", LoadSceneMode.Single);
        }
       

        timer += Time.deltaTime;
        seconds = timer % 60;
        secondscounter = (int)seconds;

        
    }
}
