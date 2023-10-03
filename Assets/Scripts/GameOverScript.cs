using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter(Collision other) {

         if(!GameManager.Instance.isGameActive){
            return;
        }



        if(other.gameObject.CompareTag("Ball")){

        Debug.Log("GAME OVER:");

        // priot message
        Destroy(other.gameObject);

        // End game
        GameManager.Instance.isGameActive = false;
        }
    
    }
}
