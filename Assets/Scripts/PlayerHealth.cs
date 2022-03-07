using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [Header("PLAYER")]
    public float startLife;
    private float currentLife;
    public float maxLife = 8f;
    [Header("INTERFACE")]
    public GameObject LifelistUI;
    private UIDisplayHealth UIsciprt;
    
  
    

    // Start is called before the first frame update
    void Start()
    {
        currentLife = startLife;
        UIsciprt = LifelistUI.GetComponent<UIDisplayHealth>();
        UIsciprt.CreateLifeUI(currentLife, maxLife);
    }


    public void ChangeHealth(float healthValue)
    {

        //clamp life <=-1 ou =>maxlife
        currentLife = currentLife + healthValue;                 //currentLife += healthValue;
        //appelle de la fonction upadate de L'UI
        //get la liste des index length = nomre d'image
        //crée les images
    }


}
