using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingScene : MonoBehaviour
{
    public GameObject logo;
    public Vector3 logoLimits;

    // Use this for initialization
    void Start()
    {
        var logoPosition = new Vector3
        {
            x = 0,
            y = 0,
            z = logoLimits.z
        };
        var logoRotation = Quaternion.identity;

        //Instantiate(logo, logoPosition, logoRotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Debug.Log("Enter here");
            SceneManager.LoadScene("MainScene");
        }
    }
}
