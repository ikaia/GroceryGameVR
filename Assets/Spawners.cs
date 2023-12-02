using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
	public GameObject male;
    public GameObject drinkPrefab;
    public GameObject peoplePrefab;
    public GameObject cakePrefab;

    public float spawnHeight = 2.0f; // Adjust this value based on your floor's height

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) // Spawn drink on 'D' key press
        {
            SpawnObject(drinkPrefab);
        }
        else if (Input.GetKeyDown(KeyCode.E)) // Spawn person on 'P' key press
        {
            SpawnObject(peoplePrefab);
        }
        else if (Input.GetKeyDown(KeyCode.C)) // Spawn cake on 'C' key press
        {
            SpawnObject(cakePrefab);
        }
		 else if (Input.GetKeyDown(KeyCode.X)) // Spawn cake on 'C' key press
        {
            SpawnObject(male);
        }
    }

    void SpawnObject(GameObject prefab)
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), spawnHeight, Random.Range(-10, 11));
        GameObject spawnedObject = Instantiate(prefab, randomSpawnPosition, Quaternion.identity);
        
        // Ensure the spawned object has a collider
        if (spawnedObject.GetComponent<Collider>() == null)
        {
            spawnedObject.AddComponent<BoxCollider>(); // Add a BoxCollider if there isn't one
        }
    }
}
