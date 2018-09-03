using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour
{
	public float XMin, XMax, ZMin, ZMax;
	public float Speed;
	public float tilt;

	public GameObject Shot;
	public float FireRate;

	private float _nextFire; 

	private Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void Update()
	{
		if ((Input.GetButton("Fire1") || Input.GetKeyDown(KeyCode.Space)) && Time.time > _nextFire)
		{
			_nextFire = Time.time + FireRate;
			var position = rb.transform.position + new Vector3(0, 0, 1.0f); 
			Instantiate(Shot, position, rb.rotation);
		}
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rb.velocity = movement * Speed;

		rb.position = new Vector3
		(
			Mathf.Clamp(rb.position.x, XMin, XMax),
			0.0f,
			Mathf.Clamp(rb.position.z, ZMin, ZMax)
		);

		rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
	}

}
