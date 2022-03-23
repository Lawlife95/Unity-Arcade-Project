using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCollider : MonoBehaviour
{
    public BoxCollider2D c2D;

    // Start is called before the first frame update
    void Start()
    {
        c2D = GetComponent<BoxCollider2D>();
    }

    public void DisableCollider()
    {
        c2D.enabled = false;
    }

    public void ReactivateCollider()
    {
        c2D.enabled = true;
    }
}
