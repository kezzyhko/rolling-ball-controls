using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rigidBody.AddForce(Vector3.up * 25000);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
            rigidBody.AddForce(Vector3.left * 1000);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward);
            rigidBody.AddForce(Vector3.right * 1000);
        }

    }
}
