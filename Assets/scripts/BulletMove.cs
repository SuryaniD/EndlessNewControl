using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour
{

    private float speed = -3.0f;
    public GameObject kogel;

    void Start()
    {
        Destroy(kogel, 5.0f);
    }


    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }



}