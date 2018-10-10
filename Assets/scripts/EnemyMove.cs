using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour
{

    public float speed = 3.0f;
    public GameObject enemy;

    void Start()
    {
        Destroy(enemy, 5.0f);
    }


    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }



}