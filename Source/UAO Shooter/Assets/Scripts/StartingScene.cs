using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartingScene : MonoBehaviour
{
    public GameObject logo;
    public Text title;
    public Text legend;
    public Text authors;
    public Vector3 logoLimits;

    // Use this for initialization
    void Start()
    {
        title.text = "";
        legend.text = "";
        authors.text = "";

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

        if(Time.time > 15f)
        {
            title.text = "UAO: A Space Shooter made in Unity";
            legend.text = "PRESS ANY KEY TO START";
            authors.text = "Authors: Guastavino - Savio - Virga";
        }
    }
}
