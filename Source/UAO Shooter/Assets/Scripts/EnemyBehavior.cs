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
        //speed = Random.Range(speed - 1, speed + 2);
        var rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = -transform.forward * speed;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
