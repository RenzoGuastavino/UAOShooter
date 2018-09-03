using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public Transform[] Enemies;
    public Vector3 enemyLimits; //-- Enemy limits (min and max position)
    public float lifeTime; //--Enemy lifeTime

    // Use this for initialization
    void Start ()
    {
        StartCoroutine(GenerateEnemies());
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    private IEnumerator GenerateEnemies()
    {
        while(true)
        {
            for(int i = 0; i<10; i++)
            {
                var enemyPosition = new Vector3
                {
                    x = Random.Range(-enemyLimits.x, enemyLimits.x),
                    y = 0,
                    z = enemyLimits.z
                };
                var enemyRotation = Quaternion.identity;

                Instantiate(Enemies[Random.Range(0, Enemies.Length)], enemyPosition, enemyRotation);
                yield return new WaitForSeconds(0.5f);
            }
            yield return new WaitForSeconds(4);
        }
    }
}
