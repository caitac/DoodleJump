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
        Invoke("AddFish", 5); 
        //for (int i = 1; i < platformCount; i++){
          //  spawnPosition.y += Random.Range(.5f, 2f);
            //spawnPosition.x = Random.Range(-10f, 10f);
            
            //Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

    }

    void Update()
    {
        Invoke("AddFish", 5); 
        
    }

    public void AddFish()
    {
        spawnPosition.y += Random.Range(.5f, 2f);
        float xValue = (Random.Range(-100f, 100f) / 5);
        spawnPosition.x = xValue; //used to be Random.Range(-10f, 10f) 
            
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
    }

    
}
