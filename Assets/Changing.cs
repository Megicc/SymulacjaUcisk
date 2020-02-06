using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changing : MonoBehaviour {

    public Vector3  positionChange;


    void Awake()
    {
        positionChange = new Vector3(0.0f, -0.01f, 0.0f);
        gameObject.transform.localPosition = new Vector3(0, 0, 0.28f);
    }
    void Update()
    {
        gameObject.transform.position += positionChange;

        if (gameObject.transform.position.y < -0.25f || gameObject.transform.position.y > 0.21f)
        {
            positionChange = -positionChange;
        }

        
    }
}
