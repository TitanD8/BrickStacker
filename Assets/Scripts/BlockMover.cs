using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMover : MonoBehaviour
{

    public bool isActiveBlock = true;
    public bool movingLeft = true;

    public float movementDelay = .05f;

    public SubBlock[] subBlocks;
    // Start is called before the first frame update
    void Start()
    {
        subBlocks = GetComponentsInChildren<SubBlock>();
        StartCoroutine(MoveBlock());   
    }

    private IEnumerator MoveBlock()
    {
        while (isActiveBlock == true)
        {
            yield return new WaitForSeconds(movementDelay);
            if (movingLeft)
            {
                if (this.transform.position.x > -17f)
                {
                    transform.position -= new Vector3(1f, 0f, 0f);
                }
                else
                {
                    transform.position += new Vector3(1f, 0f, 0f);
                    movingLeft = false;
                }
            }
            else
            {
                if (this.transform.position.x < 17f)
                {
                    transform.position += new Vector3(1f, 0f, 0f);
                }
                else
                {
                    transform.position -= new Vector3(1f, 0f, 0f);
                    movingLeft = true;
                }
            }
        }
    }

    public void StopMovement()
    {
        isActiveBlock = false;
        StartCoroutine(DropDelay());
    }

    IEnumerator DropDelay()
    {
        this.tag = "Dropped";
        yield return new WaitForSeconds(.5f);
        DropChildren();
    }

    public void DropChildren()
    {
        
        for(int i = 0; i < subBlocks.Length; i++)
        {
            subBlocks[i].EnableGravity();
        }
        SpawnController.spawnController.SpawnNewActiveBlock();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
