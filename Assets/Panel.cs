using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel : MonoBehaviour
{

    AudioSource ses;

    void Start()
    {

        gameObject.SetActive(false);

        ses = GetComponent<AudioSource>();

    }


    void Update()
    {

    }

    public void pause()
    {
        
       

        Time.timeScale = 0.0f;

        gameObject.SetActive(true);




    }

    public void resume()
    {

        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void play_again()
    {
        SceneManager.LoadScene("Scenes/SampleScene");

        Time.timeScale = 1f;

    }

    

}
