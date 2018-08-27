using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    Rigidbody rigidBody;
	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        Vector3 ajustedMovement = transform.TransformDirection(Vector3.forward);
        rigidBody.AddForce(ajustedMovement * 2000);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
