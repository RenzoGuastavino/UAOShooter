using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    public GameController gameController; 
	public GameObject Explosion; 
	//public GameObject PlayerExplosion; 
    private int currentScore;

    private void Start()
    {
        var gameControllerObject = GameObject.FindWithTag("GameController");

        if (gameControllerObject != null)
            gameController = gameControllerObject.GetComponent<GameController>();
    }
	
    void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Background") 
		{
			Debug.Log(other.name);
			return;
		}
		Instantiate(Explosion, transform.position, transform.rotation);

        if (other.tag == "Enemy")
            return;

		if (other.tag == "Player")
		{
			//Instantiate(PlayerExplosion, other.transform.position, other.transform.rotation);
			GameController.gameControllerInstance.GameOver();
		}

        currentScore += 100;
        gameController.AddScore(currentScore);
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}