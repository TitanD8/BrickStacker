using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OD_SpawnController : MonoBehaviour
{
    public int subBlocksRemaining = 6;
    public GameObject[] currentSubBlocks;
    public GameObject[] subBlockSpawns;// this will be where all the possible spawns will be stored. The Possible Spawns Are:
                                       // 6 Blocks = subBlockSpawn[5]
                                       // 5 Blocks = subBlockSpawn[4]
                                       // 4 Blocks = subBlockSpawn[3]
                                       // 3 Blocks = subBlockSpawn[2]
                                       // 2 Blocks = subBlockSpawn[1]
                                       // 1 Blocks = subBlockSpawn[0]
    public GameObject testGameObject;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        SpawnNewActiveBlock();
    }

    public void SpawnNewActiveBlock()
    {
        Transform currentPos = this.transform;
        if (subBlocksRemaining >= 1)
        {
            Instantiate(testGameObject, currentPos, false);
            transform.DetachChildren();
            StartCoroutine(MoveSpawnPoint());
        }

        
    }

    IEnumerator MoveSpawnPoint()
    {
        yield return new WaitForSeconds(.5f);
        this.transform.position += new Vector3(0f, 1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
