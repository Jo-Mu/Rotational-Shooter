using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectiles : MonoBehaviour
{
    public GameObject projectile;

    private bool shootingButtonDown = false;

    private const float projectileSpeed = 22.0f;
    public Vector3 localSpawnOffset = new Vector3(0.4f, -0.4f, 0.0f);

	void Start ()
    {
		
	}

    void FixedUpdate()
    {
        shootingButtonDown = Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0);
    }

    void Update ()
    {
        ShootOnKeyDown();
	}

    void ShootOnKeyDown()
    {
        if (shootingButtonDown)
        {
            SpawnProjectile();
        }
    }

    void SpawnProjectile()
    {
        GameObject projectileClone;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        projectileClone = Instantiate(projectile, transform.TransformPoint(Vector3.left + localSpawnOffset), Quaternion.Euler(0.0f, 0.0f, transform.eulerAngles.z)) as GameObject;
        Rigidbody2D projectileRigidbody2D = projectileClone.AddComponent<Rigidbody2D>();
        projectileRigidbody2D.velocity = mousePosition.normalized * projectileSpeed;
        projectileRigidbody2D.gravityScale = 0.0f;
    }
}
