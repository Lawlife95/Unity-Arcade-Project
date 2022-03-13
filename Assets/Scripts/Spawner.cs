using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public bool rightToLeft;
    public GameObject[] EnnemiesPrefabs;           
    public float moveSpeed;
    public float maxSpeedClamp;
    [Range(1,20)] public float SpawnWait;        // add un range aleatoire (SpawnwaitMax/spawnWaitMin)
    
   

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timerSpawn());
    }

    public IEnumerator timerSpawn()
    {
        while (1 == 1)
        {
            Instantiate(EnnemiesPrefabs[Random.Range(0,EnnemiesPrefabs.Length)], transform);     //Take Random GameObject dans l'array               //Get un gameobject random dans l'array 
            yield return new WaitForSeconds(SpawnWait);
        }
    }

     

}
