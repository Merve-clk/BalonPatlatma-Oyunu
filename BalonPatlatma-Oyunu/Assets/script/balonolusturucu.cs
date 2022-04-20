using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonolusturucu : MonoBehaviour
{
    public bool hedefmi = false, mhedefmi = false, shedefmi = false, ghedefmi = false;
    public float zamansayaci = 3;
    public GameObject balon, ok;
    public GameObject kirmizig, sarig, yesilg, mavig;

    void Start()
    {
        ok = this.gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        zamansayaci -= Time.deltaTime;
        if (zamansayaci<=0)
        {
          GameObject go =  Instantiate(balon, new Vector3(Random.Range(-1.89f, 2.11f), -8f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            
            if (ok.GetComponent<oyunkontrol>().kirmizi==true && go.gameObject.tag.Equals("kirmizi"))
            {
                hedefmi = true;
                go.GetComponent<hedef>().enabled = true;
                go.GetComponent<tuzak>().enabled = false;
            }
            if (ok.GetComponent<oyunkontrol>().mavi == true && go.gameObject.tag.Equals("mavi"))
            {
                hedefmi = true;
                go.GetComponent<hedef>().enabled = true;
                go.GetComponent<tuzak>().enabled = false;
            }
            if (ok.GetComponent<oyunkontrol>().yesil == true && go.gameObject.tag.Equals("yesil"))
            {
                hedefmi = true;
                go.GetComponent<hedef>().enabled = true;
                go.GetComponent<tuzak>().enabled = false;
            }

            if (ok.GetComponent<oyunkontrol>().sari == true == true && go.gameObject.tag.Equals("sari"))
            {
                hedefmi = true;
                go.GetComponent<hedef>().enabled = true;
                go.GetComponent<tuzak>().enabled = false;
            }

            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(100f, 200f), 0));
            zamansayaci = 3;
        }
        
    }
}
