using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/*
 * This script controls the horizontal movement of the Active Block parent object.
 * 
 */

public class OD_BlockMover : MonoBehaviour
{
    // Active Block Variables 
    public float movementSpeed = .5f;
    public bool isActiveBlock = true;
    public bool movingLeft = true;
    
    public OD_SpawnController spawnControllerScript;
    public OD_SubBlock[] subBlocks;


    // Start is called before the first frame update
    void Start()
    {
        spawnControllerScript = GameObject.FindGameObjectWithTag("Respawn").GetComponent<OD_SpawnController>();
        subBlocks = GetComponentsInChildren<OD_SubBlock>();
            
            /*new SubBlock[this.transform.childCount];

        for(int i = 0; i > this.transform.childCount; i++)
        {
            childBlocks[i] = Ge
        }

        for(int i = 0; i > this.transform.childCount; i++)
        {
            subBlocks[i] = childBlocks[i].GetComponent<SubBlock>();
        }*/

        //Start moving the main block on spawn.
        StartCoroutine(MoveBlock());
    }


    // Active Block Functions
    private IEnumerator MoveBlock()
    {
        while(isActiveBlock == true)
        {
            yield return new WaitForSeconds(movementSpeed);
            if(movingLeft)
            {
                if(this.transform.position.x > -17f)
                {
                    transform.position -= new Vector3(1f,0f,0f); 
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

    //Accessed by the Input Controller Script using Unity Events.
    public void StopMovement()
    {
        isActiveBlock = false;
        
        
        for(int i = 0; i < subBlocks.Length; i++)
        {
            subBlocks[i].StartCoroutine("DropDelay");
        }

        this.tag = "Platform";
        spawnControllerScript.SpawnNewActiveBlock();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
