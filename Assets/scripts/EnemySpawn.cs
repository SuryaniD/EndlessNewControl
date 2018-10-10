using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public Score other;
    public GameObject enemy;
    GameObject enemyClone;
    public float Timer = 2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            enemyClone = Instantiate(enemy, new Vector3(3.0f,0.0f,0), transform.rotation) as GameObject;
            Timer = Random.Range(1.5f, 3.0f);
            other.puntErbij();
        }
    }
}
