using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour {

    public Vector3 ucisk;
    Rigidbody rb;
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
	void Update () {

        if (Input.GetKey(KeyCode.M))
        {
            rb.AddForce(transform.position.y * ucisk *-1);
        }
	}
}
