using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject laser;
    private Vector3 offset = new Vector3(0.75f, 0.0f, 0.0f);
    GameObject laserClone;  

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {

           //maakt een laser bij input van de speler
            laserClone = Instantiate(laser, transform.position+offset, transform.rotation) as GameObject;
            Destroy(laserClone, 5.0f);
        }
    }
}
