using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    // intervalo 
    //cooldawn
    //lista de bolinhas 
    //ponto de origem public
    // Start is called before the first frame update
    public Vector3 originPoint = new Vector3(0,0,0);
    public List<GameObject> prefabs;
    public float interval = 1;
    public float cooldown = 0;
    

    void Start()
    {
        
    }

    void Update()
    {
        // encore game is active
        if(!GameManager.Instance.isGameActive){
            return;
        }

        cooldown -= Time.deltaTime;
        if(cooldown <= 0f) {
            cooldown = interval;
            SpawnBall();
        }
    }
    private void SpawnBall() {


        // get prefab
        int prefabIndex = Random.Range(0, prefabs.Count);
        GameObject prefab = prefabs[prefabIndex];


        // get position
        float gameWidth = GameManager.Instance.gameWidth;
        float xOffset = Random.Range(-gameWidth / 2f, gameWidth / 2f);
        Vector3 position = originPoint + new Vector3(xOffset,0,0);

        //get rotation
        Quaternion rotation = prefab.transform.rotation;

        // spawn ball
        Instantiate(prefab, position, rotation);
        
        
    }
}
