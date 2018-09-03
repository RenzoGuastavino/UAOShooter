using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{

    public float speed = 0.05F;
    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {

        float offset = Time.time * speed;
        renderer.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
