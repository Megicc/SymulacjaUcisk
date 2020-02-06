using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour {

    public GameObject bar;
    private Vector3 scaleChange, normalScale;
    public Material red;
    public Material blue;
    



    void Awake()
    {
        scaleChange = new Vector3(0.55f, 0.1f, 0.06f);
        normalScale = bar.transform.localScale;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bar"))
        {
            bar.transform.localScale = scaleChange;
            bar.GetComponent<Renderer>().material = red;
        }
    }

    void OnTriggerExit(Collider other)
        {
         if (other.CompareTag("bar"))
         {
            bar.transform.localScale = normalScale;
            bar.GetComponent<Renderer>().material = blue; ;
        }
    }

   
}
