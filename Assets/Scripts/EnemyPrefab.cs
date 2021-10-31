using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPrefab : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<EnemyPrefab>().Length;

        Debug.LogWarning("Enemy Count = " + enemyCount);
    }

   // private void OnCollisionEnter(Collision collision)
   // {
   //     float randomX = Random.Range(-1950.0f, 2950.0f);
   //     float randomZ = Random.Range(-1950.0f, 1950.0f);
   //     if (collision.collider.CompareTag("Shell"))
   //     {
   //         transform.position = new Vector3(randomX, 1.0f, randomZ);
   //     }
   // }

    private void OnTriggerEnter(Collider other)
    {
        float randomX = Random.Range(-1950.0f, 2950.0f);
        float randomZ = Random.Range(-950.0f, 1950.0f);

        float randomX2 = Random.Range(-1950.0f, 2950.0f);
        float randomZ2 = Random.Range(-950.0f, 1950.0f);
        if (other.CompareTag("Shell"))
        {
            transform.position = new Vector3(randomX, 1.0f, randomZ);
            Instantiate(enemyPrefab, new Vector3(randomX2, 1.0f, randomZ2),transform.rotation);
           
            
            Destroy(other.gameObject);
        }
    }


}
