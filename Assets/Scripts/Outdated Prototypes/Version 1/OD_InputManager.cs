using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OD_InputManager : MonoBehaviour
{
    public UnityEvent pressStop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void FixedUpdate()
    {
      if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<OD_BlockMover>().StopMovement();
            Debug.Log("Space Pressed");
            //pressStop.Invoke();
        }

        
    }
}
