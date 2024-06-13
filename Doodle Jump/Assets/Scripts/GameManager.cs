using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject player;
    public List<GameObject> platformPrefabs; // starting w base code for one platform that i will edit 
    private GameObject currentPrefab;
    //public int platformCount = 500; // game stops at this many 
    Vector3 spawnPosition = new Vector3();

    
    void Start()
    {
        StartAddFishBelow();
        StartAddFishBelow();
        StartAddFishBelow();
        StartAddFish();
        StartAddFish();
        StartAddFish();
        StartAddFish();
        StartAddFish();
        //for (int i = 1; i < platformCount; i++){
          //  spawnPosition.y += Random.Range(.5f, 2f);
            //spawnPosition.x = Random.Range(-10f, 10f);
            
            //Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

    }

    void Update()
    {
        Invoke("AddFish", 10); 
    }

    public void StartAddFishBelow() // ik this can be done without repeating code by taking in varibles (im sorry)
    {
        spawnPosition.y = (Random.Range(player.transform.position.y - 10f, (player.transform.position.y + 5f)));
        float xValue = Random.Range(-3.5f, 3.5f);
        spawnPosition.x = xValue; //used to be Random.Range(-10f, 10f) 
            
        int index = Random.Range(0, platformPrefabs.Count); 
        Instantiate(platformPrefabs[index], spawnPosition, Quaternion.identity);
    }

    public void StartAddFish() // ik this can be done without repeating code by taking in varibles (im sorry)
    {
        spawnPosition.y = (Random.Range(player.transform.position.y + 1f, (player.transform.position.y + 5f)));
        float xValue = (Random.Range(-100f, 100f) / 5);
        spawnPosition.x = xValue; //used to be Random.Range(-10f, 10f) 
            
        int index = Random.Range(0, platformPrefabs.Count); 
        Instantiate(platformPrefabs[index], spawnPosition, Quaternion.identity);
    }
    public void AddFish()
    {
        spawnPosition.y = (Random.Range(player.transform.position.y + 4f, (player.transform.position.y + 10f)));
        float xValue = (Random.Range(-100f, 100f) / 5);
        spawnPosition.x = xValue; //used to be Random.Range(-10f, 10f) 
            
        int index = Random.Range(0, platformPrefabs.Count); 
        Instantiate(platformPrefabs[index], spawnPosition, Quaternion.identity);
    }

    
}
