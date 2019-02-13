using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collisions : MonoBehaviour
{

    public GameObject obj1;
    private string Tag;
    public GameObject Scorer;
    private Scoring scoreController;
    public GameObject Explosion;

    // Use this for initialization
    private void Update()
    {
          Tag = obj1.tag;
        //Scorer = GameObject.Find("FPSController");
        //scoreController = Scorer.GetComponent<Scoring>();
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

       // scoreController.AddScore(10);
    }
}
}
