using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyAndProjectile : MonoBehaviour
{
    ScoreLogic score;

	void Start ()
    {
        score = GameObject.FindGameObjectWithTag("GUI").GetComponent<ScoreLogic>();
	}
	
	void Update ()
    {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            score.AddToScore();
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.tag == "Projectile")
        {
            Destroy(collision.gameObject);
        }
    }
}
