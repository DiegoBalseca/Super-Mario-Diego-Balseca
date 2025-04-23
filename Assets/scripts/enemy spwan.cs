using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspwan : MonoBehaviour
{
    [Header("Spawn Enemigos")]

    [Tooltip("Prefabs de enemigos")]

    [SerializeField] private GameObject[] enemiesPrefab;
    [Tooltip("Numero de enemigos que van a spwanear")]
    
    [SerializeField] private int enemiesToSpawn;
    [SerializeField] private Transform spawnPoint;
    
   
    private BoxCollider2D 
    private int enemyIndex;

    void Awake()
    {
       _collider = GetComponent<BoxCollider2D>();
    }



     // Update is called once per frame
    void Update()
    {
       // if(enemiesToSpawn <= 0)
        {
            CancelInvoke();
        }
    }

    IEnumerator SpawnEnemy()
    {
       for (int i = 0; i <enemiesToSpawn; i++)

        foreach (Transform spawn in spawnPoint)
        {
            enemyIndex = Random.Range(0, enemiesPrefab.Lenght);
            Instantiate(enemiesPrefab[enemyIndex], spawn.position, spawn.rotation);

            yield return new WaitforSeconds(1);
        }

        yield return new WaitforSeconds(1);

        enemiesToSpawn--;
       
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            _collider.enabled = false;
           // InvokeRepeating("SpawnEnemy", 0, 2);
           StartCoroutine(SpawnEnemy);
        }
    }
}
