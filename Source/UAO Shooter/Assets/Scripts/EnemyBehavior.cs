using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    //--Enemy's speed
    public float speed;

	// Use this for initialization
	void Start ()
    {
        var rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = -transform.forward * speed;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
