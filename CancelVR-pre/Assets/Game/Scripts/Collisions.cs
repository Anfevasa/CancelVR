using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collisions : MonoBehaviour
{

    public GameObject obj1;
    public GameObject Explosion;
    public GameObject Score;
    public GameObject Timer;

    private string Tag;
    
    public Scoring ScoreScript;
    public Tiempo TiempoScript;
    


    // Use this for initialization
    private void Update()
    {
          Tag = obj1.tag;

        Score = GameObject.Find("Score");
        ScoreScript = Score.GetComponent<Scoring>();

        Timer = GameObject.Find("Time");
        TiempoScript = Timer.GetComponent<Tiempo>();
        //Explosion = GameObject.Find("Explosion");
    }

private void OnCollisionEnter(Collision Other)
{
        Tag = obj1.tag;

        Score = GameObject.Find("Score");
        ScoreScript = Score.GetComponent<Scoring>();

        Timer = GameObject.Find("Time");
        TiempoScript = Timer.GetComponent<Tiempo>();

        if (Tag == "Limit")
    {
        Destroy(Other.gameObject);
    }
    if (Tag == "Bullet" & Other.gameObject.tag == "Enemy")
    {
            
            ScoreScript.AddScore(10);
            Destroy(Other.gameObject);
            Destroy(obj1);
       // var Particles = Instantiate(Explosion, Other.transform.position, Quaternion.identity);
        //Instantiate(Explosion, Other.transform.position);
       
    }

    if (Tag == "Bullet" & Other.gameObject.tag == "Enemy2")
    {
            

        ScoreScript.AddScore(20);

        Destroy(Other.gameObject);
        Destroy(obj1);
       // var Particles = Instantiate(Explosion, Other.transform.position, Quaternion.identity);
        //Instantiate(Explosion, Other.transform.position);

       
    }

    if (Tag == "Bullet" & Other.gameObject.tag == "EnemyTime")
    {
            
            TiempoScript.CountDown = TiempoScript.CountDown + 15;
            TiempoScript.tiempo = TiempoScript.tiempo + 15f;
            Destroy(Other.gameObject);
            Destroy(obj1);
            // var Particles = Instantiate(Explosion, Other.transform.position, Quaternion.identity);
            //Instantiate(Explosion, Other.transform.position);

        
    }
}
}
