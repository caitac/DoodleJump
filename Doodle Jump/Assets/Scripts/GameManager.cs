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
        // StartAddFishBelow();
        // StartAddFishBelow();
        // StartAddFishBelow();
        // StartAddFishBelow();
        // StartAddFishBelow();
        for (int i = 0; i<5; i++) {
            StartAddFish(-60f/5,60f/5, 1f, 15f);
            StartAddFish(-15f,15f, -10f, 5f);

        }
        // StartAddFish();
        // StartAddFish();
        // StartAddFish();
        // StartAddFish();
        // StartAddFish();

        StartCoroutine(AddFish());
        Debug.Log("start");
    }

    public void Update() {
        // DestroyOutOfBounds();
    }

    // public void StartAddFishBelow() // ik this can be done without repeating code by taking in varibles (im sorry)
    // {
    //     spawnPosition.y = (Random.Range(player.transform.position.y - 10f, (player.transform.position.y + 5f)));
    //     float xValue = Random.Range(-15f, 15f);
    //     spawnPosition.x = xValue; //used to be Random.Range(-10f, 10f) 
            
    //     int index = Random.Range(0, platformPrefabs.Count); 
    //     Instantiate(platformPrefabs[index], spawnPosition, Quaternion.identity);
    // }

    public void StartAddFish(float randomRangeXLow, float randomRangeXHigh, float yBuffLow, float yBuffHigh) // ik this can be done without repeating code by taking in varibles (im sorry)
    {
        spawnPosition.y = (Random.Range(player.transform.position.y + yBuffLow, (player.transform.position.y + yBuffHigh)));
        float xValue = (Random.Range(randomRangeXLow, randomRangeXHigh)); //divide by 5 to space out
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
            Instantiate(platformPrefabs[index], spawnPosition, transform.rotation);
            Debug.Log("Did it!");

            count += 1f;
            yield return new WaitForSeconds(.4f);
        }
    }

    // public void DestroyOutOfBounds() 
    //     {
    //     GameObject[] fishes = GameObject.FindGameObjectsWithTag("Fish");
    //     foreach(GameObject fish in fishes)
    //         if (fish.transform.position.y <  (player.transform.position.y - 40))
    //         {
    //             Destroy(gameObject);
    //             Debug.Log("deleted object!");
    //         }
    // }

    
}
