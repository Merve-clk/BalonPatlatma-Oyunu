using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyunkontrol : MonoBehaviour
{
    public Text puankazan, tuzakpuantext, hangibalon;
    public int a, puan=0, tuzakpuan=0;
    public bool kirmizi=false, mavi = false, sari = false, yesil = false;
    public GameObject kirmizig, sarig, yesilg, mavig;
    void Start()
    {
        int a = Random.Range(0, 4);
        if (a == 0)
        {
            kirmizi = true;
            hangibalon.color = Color.red;
            hangibalon.text = "Kýrmýzý Balonlarý Patlat";
        }
        if (a == 1)
        {
            mavi = true;
            hangibalon.text = "Mavi Balonlarý Patlat";
            hangibalon.color = Color.blue;

        }
        if (a == 2)
        {
            sari = true;
            hangibalon.text = "Sarý Balonlarý Patlat";
            hangibalon.color = Color.yellow;

        }
        if (a == 3)
        {
            yesil = true;
            hangibalon.text = "Yeþil Balonlarý Patlat";
            hangibalon.color = Color.green;

        }

        //if (kirmizi == true)
        //{
        //    kirmizig.GetComponent<hedef>().enabled = true;
        //    kirmizig.GetComponent<tuzak>().enabled = false;
        //}

        //if (mavi == true)
        //{
        //    mavig.GetComponent<hedef>().enabled = true;
        //    mavig.GetComponent<tuzak>().enabled = false;

        //}
        //if (sari == true)
        //{
        //    sarig.GetComponent<hedef>().enabled = true;
        //    sarig.GetComponent<tuzak>().enabled = false;

        //}
        //if (yesil == true)
        //{
        //    yesilg.GetComponent<hedef>().enabled = true;
        //    yesilg.GetComponent<tuzak>().enabled = false;

        //}
    }


    void Update()
    {


    }
    public void puanarttir()
    {
        puan = puan + 1;
        puankazan.text = puan.ToString();
    }
    public void puanarttirtuzak()
    {
        tuzakpuan = tuzakpuan + 1;
        tuzakpuantext.text = tuzakpuan.ToString();
    }

    public void yenidenbasla()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
