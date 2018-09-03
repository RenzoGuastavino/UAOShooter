using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
	public GameObject Explosion; // > objeto explosion del enemigo
	public GameObject PlayerExplosion; // obj explosion de la nave.

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Background") 
		{
			Debug.Log(other.name);
			return;
		}
		Instantiate(Explosion, transform.position, transform.rotation);  
		if (other.tag == "Player")
		{
			//Instantiate(PlayerExplosion, other.transform.position, other.transform.rotation);
			// GameController.GameOver();
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}