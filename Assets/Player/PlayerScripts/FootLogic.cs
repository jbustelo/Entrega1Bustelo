using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootLogic : MonoBehaviour
{
    public PlayerMovement PlayerLogic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) 
    {
        PlayerLogic.canJump = true;
    }

    private void OnTriggerExit(Collider other) 
    {
        PlayerLogic.canJump = false;
    }
}
