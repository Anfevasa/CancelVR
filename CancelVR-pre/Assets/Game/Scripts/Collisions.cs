using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collisions : MonoBehaviour
{

    public GameObject obj1;
    public GameObject Explosion;
    public GameObject Controller;
    public GameObject Time;

    private string Tag;
    
    public Scoring ScoreScript;
    public Tiempo TiempoScript;
    


    // Use this for initialization
    private void Update()
    {
          Tag = obj1.tag;

        Controller = GameObject.Find("GameController");
        ScoreScript = Controller.GetComponent<Scoring>();

        Time = GameObject.Find("Time");
        TiempoScript = Time.GetComponent<Tiempo>();
        //Explosion = GameObject.Find("Explosion");
    }

private void OnCollisionEnter(Collision Other)
{
    if (Tag == "Limit")
    {
        Destroy(Other.gameObject);
    }
    if (Tag == "Bullet" & Other.gameObject.tag == "Enemy")
    {
        Destroy(Other.gameObject);
        Destroy(obj1);
       // var Particles = Instantiate(Explosion, Other.transform.position, Quaternion.identity);
        //Instantiate(Explosion, Other.transform.position);

       ScoreScript.AddScore(10);
    }

    if (Tag == "Bullet" & Other.gameObject.tag == "Enemy2")
    {
        Destroy(Other.gameObject);
        Destroy(obj1);
       // var Particles = Instantiate(Explosion, Other.transform.position, Quaternion.identity);
        //Instantiate(Explosion, Other.transform.position);

       ScoreScript.AddScore(30);
    }

    if (Tag == "Bullet" & Other.gameObject.tag == "EnemyTime")
    {
        Destroy(Other.gameObject);
        Destroy(obj1);
            // var Particles = Instantiate(Explosion, Other.transform.position, Quaternion.identity);
            //Instantiate(Explosion, Other.transform.position);

        TiempoScript.CountDown = TiempoScript.CountDown + 10;
    }
}
}
