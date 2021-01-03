using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class play : MonoBehaviour
{

    public Text puan;
    

    // Start is called before the first frame update
    void Start()
    {
        int enYuksekPuan = PlayerPrefs.GetInt("kayit");
        puan.text = "BEST \nSCORE: " + enYuksekPuan;
        int reklam_sayac = PlayerPrefs.GetInt("reklamsayacı");

        if (reklam_sayac==3)
        {
            GameObject.FindGameObjectWithTag("reklam").GetComponent<Reklamlar>().ReklamGoster();
            PlayerPrefs.SetInt("reklamsayacı",0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameplay()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
        Time.timeScale = 1f;
    }
}
