 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    float randY;
    Vector2 wheretoSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randY = Random.Range(-5f, 5f);
            wheretoSpawn = new Vector2(transform.position.x, randY);
            Instantiate(enemy, wheretoSpawn, Quaternion.identity);
        }
    }
}
