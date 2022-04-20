using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuzak : MonoBehaviour
{
    public GameObject gamemanager,patlama;
    void Start()
    {
        gamemanager = GameObject.Find("GameMaster");
    }

    void Update()
    {
       
    }
    private void OnMouseDown()
    {
        if (this.gameObject.GetComponent<hedef>().enabled==true && this.gameObject.GetComponent<tuzak>().enabled == false)
        {
            gamemanager.GetComponent<oyunkontrol>().puanarttirtuzak();
            GameObject a = Instantiate(patlama, this.transform.position, this.transform.rotation);
            Destroy(a, 0.3f);
            Destroy(this.gameObject);
        }
        
    }
}
