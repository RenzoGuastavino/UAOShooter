using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBehaviour : MonoBehaviour {
	
	public float Speed;
	private Rigidbody rb;
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		rb.velocity = transform.forward * Speed;
	}
}
