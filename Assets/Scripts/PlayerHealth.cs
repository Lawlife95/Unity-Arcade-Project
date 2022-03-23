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
    public GameObject scoreArea;
    private UIScore uIscore;
    private bool isStarting;
    public int frogNumber;
    

    // Start is called before the first frame update
    void Start()
    {
        uIscore = scoreArea.GetComponent<UIScore>();
        currentLife = startLife;
        UIsciprt = LifelistUI.GetComponent<UIDisplayHealth>();
        UIsciprt.CreateLifeUI(currentLife, maxLife);
        Respawn();
        isStarting = true;
    }


    public void ChangeHealth(float healthValue)
    {

        //clamp life <=-1 ou =>maxlife   (si <1 appelle fonction Loose Window
        currentLife = currentLife + healthValue;                 //currentLife += healthValue;
        UIsciprt.updateLifeUI(currentLife);
        if (currentLife <= 0)
        {
            StartCoroutine (LifeCountCheck());
        }
    }

    public void Respawn()
    {
        transform.position = new Vector3(RespawnPoint.transform.position.x, RespawnPoint.transform.position.y, 0);
        if (isStarting)
        {
            uIscore.ResetScoreArea(); //reset de position
        }
        
    }

    public void addfrog(int frog)
    {
        frogNumber = frogNumber + frog;
        if(frogNumber >= 5)
        {
            //Victory Screen
            Debug.Log("You win");
        }
    }

    public IEnumerator LifeCountCheck()
    {
        yield return new WaitForSeconds(0.5f);
        if (currentLife <= 0)
        {
            //death screen
            Debug.Log("You loose");
        }

    }
}
