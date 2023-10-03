using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
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
        Destroy(other.gameObject);
        GameManager.Instance.score++;

        Debug.Log("Score:"+GameManager.Instance.score);
        }
    
    }
}