using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.25f;
    
    
    // Start is called before the first frame update
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
         if(!GameManager.Instance.isGameActive){
            return;
        }
        //transform.position += new Vector3(1,0,0);

        bool isPressingLeft = Input.GetKey(KeyCode.LeftArrow);
        bool isPressingRight = Input.GetKey(KeyCode.RightArrow);
        Debug.Log("Left" + isPressingLeft + ", Right" + isPressingRight);

        //abort if no keys are pressed, or both keys are pressed at the same time

        if(isPressingLeft == isPressingRight){
            return;
        }

        // move PlayerController
        float movement = speed * Time.deltaTime;
        if(isPressingLeft){
            movement += -0.07f;
        }else if(isPressingRight){
            movement += +0.07f;

        }
       

        transform.position += new Vector3(movement, 0,0);

        //limit Player
        float movementLimit = GameManager.Instance.gameWidth / 2;
        if(transform.position.x< -movementLimit){
            transform.position = new Vector3(-movementLimit,transform.position.y,transform.position.z);
        }else if(transform.position.x > movementLimit){
            transform.position = new Vector3(movementLimit,transform.position.y,transform.position.z);
        
    }
}
}