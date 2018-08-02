using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public GameObject enemy;

    private const float maxX = 29.0f;
    private const float maxY = 13.0f;
    private const float enemySpawnTimeTopLeft = 1.2f;
    private const float enemySpawnTimeTopRight = 3.2f;
    private const float enemySpawnTimeBottomLeft = 2.4f;
    private const float enemySpawnTimeBottomRight = 1.6f;
    private const float enemySpawnTimeTop = 10.3f;
    private const float enemySpawnTimeBottom = 8.6f;

    private Vector3 enemySpawnLocationTopLeft = new Vector3(-maxX, maxY, 0);
    private Vector3 enemySpawnLocationTopRight = new Vector3(maxX, maxY, 0);
    private Vector3 enemySpawnLocationBottomLeft = new Vector3(-maxX, -maxY, 0);
    private Vector3 enemySpawnLocationBottomRight = new Vector3(maxX, -maxY, 0);
    private Vector3 enemySpawnLocationTop = new Vector3(0, maxY, 0);
    private Vector3 enemySpawnLocationBottom = new Vector3(0, -maxY, 0);

    public bool canSpawnEnemyTopLeft = true;
    public bool canSpawnEnemyTopRight = true;
    public bool canSpawnEnemyBottomLeft = true;
    public bool canSpawnEnemyBottomRight = true;
    public bool canSpawnEnemyTop = true;
    public bool canSpawnEnemyBottom = true;

    void Start ()
    {
        StartCoroutine(EnemySpawnerTopLeft());
        StartCoroutine(EnemySpawnerTopRight());
        StartCoroutine(EnemySpawnerBottomLeft());
        StartCoroutine(EnemySpawnerBottomRight());
        StartCoroutine(EnemySpawnerTop());
        StartCoroutine(EnemySpawnerBottom());
    }
	
	void Update ()
    {
		
	}

    IEnumerator EnemySpawnerTopLeft()
    {
        while (canSpawnEnemyTopLeft)
        {
            SpawnEnemyTopLeft();
            yield return new WaitForSeconds(enemySpawnTimeTopLeft);
        }
    }

    IEnumerator EnemySpawnerTopRight()
    {
        while (canSpawnEnemyTopRight)
        {
            SpawnEnemyTopRight();
            yield return new WaitForSeconds(enemySpawnTimeTopRight);
        }
    }

    IEnumerator EnemySpawnerBottomLeft()
    {
        while (canSpawnEnemyBottomLeft)
        {
            SpawnEnemyBottomLeft();
            yield return new WaitForSeconds(enemySpawnTimeBottomLeft);
        }
    }

    IEnumerator EnemySpawnerBottomRight()
    {
        while (canSpawnEnemyBottomRight)
        {
            SpawnEnemyBottomRight();
            yield return new WaitForSeconds(enemySpawnTimeBottomRight);
        }
    }

    IEnumerator EnemySpawnerTop()
    {
        while (canSpawnEnemyTop)
        {
            SpawnEnemyTop();
            yield return new WaitForSeconds(enemySpawnTimeTop);
        }
    }

    IEnumerator EnemySpawnerBottom()
    {
        while (canSpawnEnemyBottom)
        {
            SpawnEnemyBottom();
            yield return new WaitForSeconds(enemySpawnTimeBottom);
        }
    }

    void SpawnEnemyTopLeft()
    {
        Instantiate(enemy, enemySpawnLocationTopLeft, Quaternion.identity);
    }

    void SpawnEnemyTopRight()
    {
        Instantiate(enemy, enemySpawnLocationTopRight, Quaternion.identity);
    }

    void SpawnEnemyBottomLeft()
    {
        Instantiate(enemy, enemySpawnLocationBottomLeft, Quaternion.identity);
    }

    void SpawnEnemyBottomRight()
    {
        Instantiate(enemy, enemySpawnLocationBottomRight, Quaternion.identity);
    }

    void SpawnEnemyTop()
    {
        Instantiate(enemy, enemySpawnLocationTop, Quaternion.identity);
    }

    void SpawnEnemyBottom()
    {
        Instantiate(enemy, enemySpawnLocationBottom, Quaternion.identity);
    }
}
