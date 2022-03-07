using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public bool rightToLeft;
    public GameObject EnnemiesPrefabs;
    public float moveSpeed;
    public float maxSpeedClamp;
    [Range(1,20)] public float SpawnWait; // add un range aleatoire
    

    // Start is called before the first frame update
    void Start()
    {
        // au lancement de la partie demarre une boucle
        StartCoroutine(timerSpawn());
    }

    public IEnumerator timerSpawn()
    {
        while (1 == 1)
        {
            Instantiate(EnnemiesPrefabs, transform);
            yield return new WaitForSeconds(SpawnWait);
        }

    }


}
