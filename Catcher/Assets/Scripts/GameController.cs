using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameObject food;
    public GameObject bomb;
    public Vector3 spawnValues;
    public Vector3 spawnValuesBomb;
    public int foodCount;
    public int bombCount;
    public float spawnWait;
    public float startWait;
    public float bombSpawnWait;
    public static int score;
    public static int lives;
    public TextMeshPro pointsCounter;
    public TextMeshPro livesCounter;

    void Start()
    {
        score = 0;
        lives = 3;
        livesCounter.text = "Lives: " + lives;
        pointsCounter.text = "Score: " + score;
        StartCoroutine (SpawnWaves());
        StartCoroutine (SpawnBombs());
    }

    void Update()
    {
        livesCounter.text = "Lives: " + lives;
        pointsCounter.text = "Score: " + score;
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < foodCount; i++)
            {
                Vector3 foodSpawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion foodSpawnRotation = Quaternion.identity;
                Instantiate(food, foodSpawnPosition, foodSpawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
        }
    }

    IEnumerator SpawnBombs()
    {
        yield return new WaitForSeconds(startWait);
        while(true)
        {
            for(int i = 0; i < bombCount; i++)
            {
                Vector3 bombSpawnPosition = new Vector3(Random.Range(-spawnValuesBomb.x, spawnValuesBomb.x), spawnValuesBomb.y, spawnValuesBomb.z);
                Quaternion bombSpawnRotation = Quaternion.identity;
                Instantiate(bomb, bombSpawnPosition, bombSpawnRotation);
                yield return new WaitForSeconds(bombSpawnWait);
            }
        }
    }
}
