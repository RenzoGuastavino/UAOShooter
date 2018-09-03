using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour
{
	public float XMin, XMax, ZMin, ZMax;
	public float Speed;
	private Rigidbody rb;
	public float tilt;

	void Start() {
		rb = GetComponent<Rigidbody>();
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
