using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private const float enemySpeed = 0.5f;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        MoveEnemyToPlayer();
	}

    void MoveEnemyToPlayer()
    {
        transform.position = Vector3.Slerp(transform.position, new Vector3(0.0f, 0.0f, 0.0f), enemySpeed * Time.deltaTime);
    }
}
