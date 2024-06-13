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

    public float count; 

    void Start()
    {
        StartAddFishBelow();
        StartAddFishBelow();
        StartAddFishBelow();
        StartAddFishBelow();
        StartAddFishBelow();
        StartAddFishBelow();
        StartAddFish();
        StartAddFish();
        StartAddFish();
        StartAddFish();
        StartAddFish();
        StartAddFish();
        StartAddFish();

        StartCoroutine(AddFish());
        Debug.Log("start");
    }

    public void StartAddFishBelow() // ik this can be done without repeating code by taking in varibles (im sorry)
    {
        spawnPosition.y = (Random.Range(player.transform.position.y - 10f, (player.transform.position.y + 5f)));
        float xValue = Random.Range(-15f, 15f);
        spawnPosition.x = xValue; //used to be Random.Range(-10f, 10f) 
            
        int index = Random.Range(0, platformPrefabs.Count); 
        Instantiate(platformPrefabs[index], spawnPosition, Quaternion.identity);
    }

    public void StartAddFish() // ik this can be done without repeating code by taking in varibles (im sorry)
    {
        spawnPosition.y = (Random.Range(player.transform.position.y + 1f, (player.transform.position.y + 15f)));
        float xValue = (Random.Range(-60f, 60f) / 5);
        spawnPosition.x = xValue; //used to be Random.Range(-10f, 10f) 
            
        int index = Random.Range(0, platformPrefabs.Count); 
        Instantiate(platformPrefabs[index], spawnPosition, Quaternion.identity);
    }
    
    IEnumerator AddFish()
    {
        while(count <1000)
        {
            Debug.Log("Actually started");
            spawnPosition.y = player.transform.position.y + 10f;
            float xValue = (Random.Range(-60f, 60f) / 5);
            spawnPosition.x = xValue; //used to be Random.Range(-10f, 10f) 
                
            int index = Random.Range(0, platformPrefabs.Count); 
            Instantiate(platformPrefabs[index], spawnPosition, Quaternion.identity);
            Debug.Log("Did it!");

            count += 1f;
            yield return new WaitForSeconds(.4f);
        }
    }

    
}
