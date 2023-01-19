using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubBlock : MonoBehaviour
{
    public Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    public void EnableGravity()
    {
        rb2D.gravityScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
