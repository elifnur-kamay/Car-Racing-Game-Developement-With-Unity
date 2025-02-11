using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public Transform[] waypoints; // NPC'nin takip edece�i yol noktalar�
    public float speed = 10f; // NPC'nin h�z�
    public float turnSpeed = 5f; // D�n�� h�z�
    private int currentWaypointIndex = 0;

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (waypoints.Length == 0) return;

        // Hedef waypoint'e do�ru hareket et
        Transform targetWaypoint = waypoints[currentWaypointIndex];
        Vector3 direction = targetWaypoint.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction);

        // NPC araban�n d�n���
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);

        // NPC araban�n hareketi
        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, speed * Time.deltaTime);

        // Hedef waypoint'e ula��ld���nda bir sonraki waypoint'e ge�
        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }
}
