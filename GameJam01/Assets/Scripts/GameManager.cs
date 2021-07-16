using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float timeBetweenSpawn;
    public int enemyAmount; 


    private void Start()
    {
        StartCoroutine(spawnEnemy());
    }
    public void Update()
    {
        if (timeBetweenSpawn <= 0.36)
        {
            SceneManager.LoadScene(2);
        }
    }
    private IEnumerator spawnEnemy()
    {
        int countSpawn = 0;
        while (countSpawn < enemyAmount)
        {
            countSpawn += 3;
            SpawnOneEnemy();
            SpawnOneEnemy();
            SpawnOneEnemy();


            if (countSpawn % 9 == 0 && countSpawn <= 100)
            {
                timeBetweenSpawn -= 0.15f;
            }

            yield return new WaitForSeconds(timeBetweenSpawn);
        }
    }
    public void SpawnOneEnemy()
    {
        int xPos = Random.Range(-15, 15);
        int yPos = Random.Range(-15, 15);
        Instantiate(enemyPrefab, new Vector3(xPos, yPos, 100), Quaternion.identity);
    }
}
