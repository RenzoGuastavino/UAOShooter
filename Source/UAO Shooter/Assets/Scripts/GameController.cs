using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Transform[] Enemies;
    public Vector3 enemyLimits; //-- Enemy limits (min and max position)
    public float lifeTime; //--Enemy lifeTime
	public static GameController gameControllerInstance;

	// public GUIText scoreText;
    public Text scoreText;
    private int currentScore = 0;

	// Use this for initialization
    void Start ()
    {
        AddScore(currentScore);
		gameControllerInstance = this;
		StartCoroutine(GenerateEnemies());
    }

    public void AddScore(int score)
    {
        currentScore += score;
        scoreText.text = $"SCORE: {currentScore}";
    }

	public void GameOver()
	{
		SceneManager.LoadScene("StartingScene");
		//LoadFirstScene();
	}

	private IEnumerator GenerateEnemies()
    {
        while(true)
        {
            for(int i = 0; i<10; i++)
            {
                var enemyPosition = new Vector3
                {
                    x = UnityEngine.Random.Range(-enemyLimits.x, enemyLimits.x),
                    y = 0,
                    z = enemyLimits.z
                };
                var enemyRotation = Quaternion.identity;

                Instantiate(Enemies[UnityEngine.Random.Range(0, Enemies.Length)], enemyPosition, enemyRotation);
                yield return new WaitForSeconds(0.5f);
            }
            yield return new WaitForSeconds(4);
        }
    }

	private IEnumerable LoadFirstScene()
	{
		while (true)
		{
			// SceneManager.LoadScene(0);
			yield return new WaitForSeconds(1);
		}
		// yield return new WaitForSeconds(3);
		// Debug.Log(" LoadScene TEST !!!");
		
	}
}
