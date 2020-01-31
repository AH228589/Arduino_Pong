using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float xVel, yVel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(xVel, yVel);

        GetComponent<Renderer>().material.mainTextureOffset += offset * Time.deltaTime;
    }
}
