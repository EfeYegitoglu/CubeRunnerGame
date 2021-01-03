using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YANDIN : MonoBehaviour
{
    public Text puan;
    
    void Start()
    {
        
        int enYuksekPuan = PlayerPrefs.GetInt("kayit");

        puan.text = "BEST SCORE: " + enYuksekPuan;
    }

    
    void Update()
    {
        
    }

    
}
