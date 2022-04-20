using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonyonetici : MonoBehaviour
{

    void Start()
    {
        if (this.gameObject.GetComponent<hedef>().enabled == false)
        {
            this.gameObject.GetComponent<tuzak>().enabled = true;
        }
    }


    void Update()
    {
        
    }
}
