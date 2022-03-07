using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDisplayHealth : MonoBehaviour
{
    [Header("Interface")]
    public GameObject PrefabsLife;
    public float lifeDistance;
    public GameObject[] UILifeArray;
    private GameObject Life;                
    private int maxlifeInt;                 //Conversion de Float maxlife pour definir la taille de l'array
    

    public void CreateLifeUI(float currentlife, float maxlife)
    {
        maxlifeInt = ((int)maxlife);
        UILifeArray = new GameObject[maxlifeInt];
        SetupLife(maxlife, currentlife);
    }

    public void SetupLife(float maxlife, float currentlife)
    {
        for (int i = 0; i < maxlife; i++) { 
            //empeche si I = 0
            
        Life  = Instantiate(PrefabsLife,new Vector3(transform.position.x + (i*lifeDistance), transform.position.y, transform.position.z), transform.rotation, transform);
        UILifeArray[i] = Life;    //add dans larray
    }
        updateLifeUI(currentlife);                  //set visibility
    }


    public void updateLifeUI(float currentlife)
    {
        for (int i = 0; i < UILifeArray.Length; i++)
        {
            if (i >= currentlife)                           
                UILifeArray[i].SetActive(false);
            if (i < currentlife)
                UILifeArray[i].SetActive(true);                             //A opti (ne rien set si deja activé ou deja desactivé
        }

    }
}