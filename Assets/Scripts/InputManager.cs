using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public static InputManager _inputManager;

    public BlockMover currentMovingBlock;

    private void OnEnable()
    {
        _inputManager = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetCurrentInputBlock()
    {
        currentMovingBlock = GameObject.FindGameObjectWithTag("ActiveBlock").GetComponent<BlockMover>();
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space))
        {
            currentMovingBlock.StopMovement();
            Debug.Log("Space Pressed");
            //pressStop.Invoke();
        }

        
    }
}
