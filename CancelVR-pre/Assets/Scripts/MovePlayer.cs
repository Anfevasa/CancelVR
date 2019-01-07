using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour
{
    
    public Transform target;
    public float speed;
    public GameObject myObject;
    private float timer = 0.0f;
    private float crono;
    int seconds = 0;
    public GameObject TextGen;
    public GameObject Totems;
    public GameObject TextTotems;
    public GameObject Mummy;
    public GameObject TextMummy;
    public GameObject Rocks;
    public GameObject TextRocks;
    private bool flag = false;
    private Text txt;

    void Update()
    {
        bool test = GlobalVariables.activate;
        if (test)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            //if (transform.position == target.position) {
            //   // TextGen.SetActive(true);


            //    timer += Time.deltaTime;
            //    crono = timer % 60;
            //    seconds = (int)crono;

            //    if (seconds > 3) {
            //        Totems.SetActive(true);
            //        TextGen.SetActive(false);
            //        TextTotems.SetActive(true);

            //    }
            //    if (seconds > 9)
            //    {
            //        Mummy.SetActive(true);
            //        TextTotems.SetActive(false);
            //        TextMummy.SetActive(true);
            //    }
            //    if (seconds > 15)
            //    {
            //        Rocks.SetActive(true);
            //        TextMummy.SetActive(false);
            //        TextRocks.SetActive(true);
            //    }
            //    if (seconds > 21)
            //    {
            //        TextRocks.SetActive(false);
            //        GlobalVariables.activate = false;
            //        GlobalVariables.TimeToactivate = false;
            //        myObject.SetActive(true);
            //    }
            //}
}
    }
}
