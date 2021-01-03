using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Enemy : MonoBehaviour
{
    public GameObject Enemy;
    public Vector3 RandomPos;

    void Start()
    {
        StartCoroutine(Olustur());
    }

    IEnumerator Olustur()
    {
        while (true)
        {
            for (int i = 0; i < 15; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-RandomPos.x, RandomPos.x), 1.05f, RandomPos.z);
                Instantiate(Enemy, vec, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
            }
            yield return new WaitForSeconds(1f);
        }
    }

    void Update()
    {
       
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "sınır")
        {
            Destroy(col.gameObject);
        }


    }
}
