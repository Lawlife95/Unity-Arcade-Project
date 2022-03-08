using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [Header("PLAYER")]
    public float startLife;
    private float currentLife;
    [Range (1, 20)]public int maxLife = 8;
    public GameObject RespawnPoint;
    [Header("INTERFACE")]
    public GameObject LifelistUI;
    private UIDisplayHealth UIsciprt;
    
  
    

    // Start is called before the first frame update
    void Start()
    {
        currentLife = startLife;
        UIsciprt = LifelistUI.GetComponent<UIDisplayHealth>();
        UIsciprt.CreateLifeUI(currentLife, maxLife);
        Respawn();
    }


    public void ChangeHealth(float healthValue)
    {

        //clamp life <=-1 ou =>maxlife   (si <1 appelle fonction Loose Window
        currentLife = currentLife + healthValue;                 //currentLife += healthValue;
        UIsciprt.updateLifeUI(currentLife);

    }

    public void Respawn()
    {
        transform.position = new Vector3(RespawnPoint.transform.position.x, RespawnPoint.transform.position.y, 0);
    }


}
