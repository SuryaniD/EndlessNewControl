using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    
public class PlayerJump : MonoBehaviour {

    public bool canJump = false;
    public float jumpHeight = 30f;
    private Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Floor")
        {
            canJump = true;
            Debug.Log("Vloer!");

        }

        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("Vijand!");
            SceneManager.LoadScene("GameOver");
        }
    }

  



    // Update is called once per frame
    void Update() {


        if (Input.GetButtonDown("Fire1") && canJump == true)
        {
            rb.AddForce(Vector3.up * jumpHeight);
            canJump = false;
        }

    }


}
