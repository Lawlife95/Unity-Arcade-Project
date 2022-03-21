using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    private BoxCollider2D bC2D;
    private float score;
    private float posY;
    public UnityEngine.UI.Text textScore;



    // Start is called before the first frame update
    void Start()
    {
        bC2D = GetComponent<BoxCollider2D>();
        posY = transform.position.y;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (transform.position.y >= 8.5f)
            {
                ResetScoreArea();
            }
            transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            score = score + 100;
            UpdateScoreUI();
        }
    }

    public void ResetScoreArea()
    {
        transform.position = new Vector3(transform.position.x, posY, transform.position.z);
    }

    public void UpdateScoreUI()
    {
        textScore.text = score.ToString();

    }

    public void scoreGain(float gain)
    {
        score = score + gain;
        UpdateScoreUI();
    }
}