using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OD_SubBlock : MonoBehaviour
{
    public bool isSafe = true;
    public Rigidbody2D rb;
    private BoxCollider2D subBlockCollider;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        subBlockCollider = GetComponent<BoxCollider2D>();
    }

    public void InitiateDropDelay()
    {
        StartCoroutine(DropDelay());
    }

    public IEnumerator DropDelay()
    {
        subBlockCollider.size = new Vector2(1f, 1f);
        subBlockCollider.offset = new Vector2(0f, 0f);
        yield return new WaitForSeconds(.5f);
        DropBlock();
    }

    private void DropBlock()
    {
        if(!isSafe)
        {
            rb.gravityScale = 1f;
        }
        else
        {
            
            subBlockCollider.isTrigger = true;
            
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Platform")
        {
            isSafe = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Platform")
        {
            isSafe = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
