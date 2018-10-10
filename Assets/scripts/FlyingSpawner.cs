using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingSpawner : MonoBehaviour {

    public GameObject fly;
    GameObject flyClone;
    public float Timer = 2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            flyClone = Instantiate(fly, new Vector3(0.0f, 3.0f, 0), transform.rotation) as GameObject;
            Destroy(flyClone, 5.0f);
            Timer = Random.Range(1.5f, 3.0f);
        }
    }
}
