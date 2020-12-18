using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] balloons;

    public GameObject playBtn;

    
    // Start is called before the first frame update
    void Start()
    {
        
       //StartCoroutine(StartSpawning());
    }

    public void Comenzar()
    {
        StartCoroutine(StartSpawning());
        playBtn.SetActive(false);
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(1);

        for (int i = 0; i < 5; i++)
        {
            Vector3 Ranposition = new Vector3(Random.Range(-2.0f, 1.0f), 0, Random.Range(3.0f, 1.0f));
            //Vector3 Ranposition = new Vector3(Random.Range(-50.0f, 50.0f), 0, Random.Range(50.0f, -50.0f));

            Instantiate(balloons[i], Ranposition, Quaternion.identity);

            //Instantiate(balloons[i], spawnPoints[i].position, Quaternion.identity);
        }

        StartCoroutine(StartSpawning());
    }
    
}
