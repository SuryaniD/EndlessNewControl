using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingMove : MonoBehaviour {

    public float speed = 3.0f;
    private Score other;
    public GameObject scripthouder;

    // Use this for initialization
    void Start () {
        GameObject scripthouder = GameObject.Find("Player");
        other = scripthouder.GetComponent<Score>();
    }

    void OnTriggerEnter(Collider bots)
    {
        Debug.Log("Raak = " + bots.gameObject.tag);
        if (bots.gameObject.tag == "Laser") {
            //Destroy(bots.gameObject);
            Destroy(gameObject);
            other.puntErbij();
        }
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        
    }


}

