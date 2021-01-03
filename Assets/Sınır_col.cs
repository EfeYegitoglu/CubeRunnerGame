using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sınır_col : MonoBehaviour
{

    AudioSource ses;
    // Start is called before the first frame update
    void Start()
    {
        ses = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {



        if (col.gameObject.name == "Player")
        {
            ses.Play();
            Invoke("ol", 1f);

        }
    }
    void ol()
    {

        SceneManager.LoadScene("Scenes/Menu");
    }
}
