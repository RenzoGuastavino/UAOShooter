using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestroyer : MonoBehaviour
{
    //--Object lifeTime
    public float lifeTime;

    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, lifeTime);
    }
}
