using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{

    Rigidbody rb;
    public float Hiz = 1f;
    bool stop = false;
    
    AudioSource[] sesler;
    int reklam_sayac = 0;




    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sesler = GetComponents<AudioSource>();
        reklam_sayac = PlayerPrefs.GetInt("reklamsayacı");
        reklam_sayac++;
        PlayerPrefs.SetInt("reklamsayacı", reklam_sayac);
    }


    void Update()
    {
        /*if (Input.GetMouseButtonDown(1))
        {
            this.transform.Translate(0.88f, 0, 0);
            //rb.AddForce(50*Time.deltaTime,0,0);

        }
        if (Input.GetMouseButtonDown(0))
        {
            rb.transform.Translate(-0.88f, 0, 0);

        }*/

        //float hinput = SimpleInput.GetAxis("Horizontal") * KarakterHiz;
        //rb.transform.Translate(hinput, 0, 0);
        

    }

    public void left()
    {
        
        rb.transform.Translate(-Hiz,0,0);
        sesler[0].Play();
    }
    public void right()
    {

        rb.transform.Translate(Hiz, 0, 0);
        sesler[0].Play();

    }

    public void pause()
    {
        stop =! stop;
        if (stop==true)
        {
            Time.timeScale = 0.0f;
        }
        
    }

    /*void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == "enemy")
        {
            //sesler[1].Play();
            
            //SceneManager.LoadScene("Scenes/Menu");
            //Invoke("ol",2);
        }
       
    }

    void ol()
    {
       
            Time.timeScale = 0.0f;
            SceneManager.LoadScene("Scenes/Menu");
        
        
        
    }*/







    }
