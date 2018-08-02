using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationalMovement : MonoBehaviour
{
    const float angleOffset = 30.0f;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        RotateToMousePoint();
	}

    void RotateToMousePoint()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10.0f);
        float angle = AngleBetweenPoints(transform.position, mousePosition);
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle - angleOffset);
    }

    float AngleBetweenPoints(Vector2 pointA, Vector2 pointB)
    {
        return Mathf.Atan2(pointA.y - pointB.y, pointA.x - pointB.x) * Mathf.Rad2Deg;
    }
}
