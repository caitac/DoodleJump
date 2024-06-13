using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public List<GameObject> platformPrefabs; // starting w base code for one platform that i will edit 
    private GameObject currentPrefab;
    //public int platformCount = 500; // game stops at this many 
    Vector3 spawnPosition = new Vector3();

    
    void Start()
    {
        
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
        // //!! set visiblity 
        // for (int i = 0; i < platformPrefabs.count; i++)
        // {
        //     platformPrefabs[i].SetActive(true);
        // }
        
        spawnPosition.y += Random.Range(.5f, 2f);
        float xValue = (Random.Range(-100f, 100f) / 5);
        spawnPosition.x = xValue; //used to be Random.Range(-10f, 10f) 
            
        int index = Random.Range(0, platformPrefabs.Count); 
        Instantiate(platformPrefabs[index], spawnPosition, Quaternion.identity);
    }

    
}
