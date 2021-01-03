using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy_hataket : MonoBehaviour
{
    
    Rigidbody fizik;
    public float hiz;
    AudioSource ses;
    
    
    
    void Start()
    {
        
        fizik = GetComponent<Rigidbody>();
        ses = GetComponent<AudioSource>();
        //fizik.velocity = transform.forward * -hiz;
       
    }

    
    void Update()
    {
        
        fizik.velocity = transform.forward * -hiz;
        
        
        //fizik.AddForce(0, 0, 200f * Time.deltaTime);
        
    }
    void FixedUpdate()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name=="sınır")
        {
            Destroy(col.gameObject);
        }

        if(col.gameObject.name=="Player")
        {
            ses.Play();
            
            Invoke("ol",1f);
        }
        

    }

    void ol()
    {

        SceneManager.LoadScene("Scenes/Menu");
    }

}
