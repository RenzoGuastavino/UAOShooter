using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
	public GameObject Explosion; 
	//public GameObject PlayerExplosion; 
	public GameController gameController;

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
			gameController.GameOver();
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}