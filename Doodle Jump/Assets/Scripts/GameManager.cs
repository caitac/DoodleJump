using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab; // starting w base code for one platform that i will edit 
    //public int platformCount = 500; // game stops at this many 
    Vector3 spawnPosition = new Vector3();
    
    void Start()
    {
        //!! set visiblity 
        
        //for (int i = 1; i < platformCount; i++){
          //  spawnPosition.y += Random.Range(.5f, 2f);
            //spawnPosition.x = Random.Range(-10f, 10f);
            
            //Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

    }

    void Update()
    {
        Invoke("AddFish", 2); 

        //check if off screen and delete if yas 
    }

    public void AddFish()
    {
        spawnPosition.y += Random.Range(.5f, 2f);
        spawnPosition.x = Random.Range(-10f, 10f);
            
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
    }
}
