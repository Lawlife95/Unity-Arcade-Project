using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public bool rightToLeft;
    public GameObject EnnemiesPrefabs;           //array list Prefab possible
                                                 //Spawn rate des camions
    public float moveSpeed;
    public float maxSpeedClamp;
    [Range(1,20)] public float SpawnWait; // add un range aleatoire
    
   

    // Start is called before the first frame update
    void Start()
    {
        //initialisation de l'array (ennemie list)
        StartCoroutine(timerSpawn());
    }

    public IEnumerator timerSpawn()
    {
        while (1 == 1)
        {
            Instantiate(EnnemiesPrefabs, transform);                    //Get un gameobject random dans l'array 
            yield return new WaitForSeconds(SpawnWait);
        }
    }


}
