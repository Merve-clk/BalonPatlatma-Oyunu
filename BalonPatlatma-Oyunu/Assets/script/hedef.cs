using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hedef : MonoBehaviour
{
   // oyunkontrol ok;
    public GameObject gamemanager, patlama;
    void Start()
    {
        gamemanager = GameObject.Find("GameMaster");
    }


    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (this.gameObject.GetComponent<hedef>().enabled==false && this.gameObject.GetComponent<tuzak>().enabled==true)
        {
            gamemanager.GetComponent<oyunkontrol>().puanarttir();
            GameObject a = Instantiate(patlama, this.transform.position, this.transform.rotation);
            Destroy(a, 0.3f);
            Destroy(this.gameObject);
        }
        
    }
}
