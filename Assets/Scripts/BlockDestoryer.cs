using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestoryer : MonoBehaviour
{
    public static BlockDestoryer blockDestoryer;

    private void OnEnable()
    {
        blockDestoryer = this;
    }

    public void MoveDestoryer()
    {
        this.transform.position += new Vector3(0f, 1f, 0f);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Dropped")
        {
            Destroy(other.gameObject);
            SpawnController.spawnController.subBlocksRemaining -= 1;
        }
    }
}
