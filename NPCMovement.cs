using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public Transform[] waypoints; // NPC'nin takip edeceði yol noktalarý
    public float speed = 10f; // NPC'nin hýzý
    public float turnSpeed = 5f; // Dönüþ hýzý
    private int currentWaypointIndex = 0;

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (waypoints.Length == 0) return;

        // Hedef waypoint'e doðru hareket et
        Transform targetWaypoint = waypoints[currentWaypointIndex];
        Vector3 direction = targetWaypoint.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction);

        // NPC arabanýn dönüþü
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);

        // NPC arabanýn hareketi
        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, speed * Time.deltaTime);

        // Hedef waypoint'e ulaþýldýðýnda bir sonraki waypoint'e geç
        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }
}
