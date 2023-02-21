using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollow : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypintIndex = 0;

    [SerializeField] private float speed = 2f;
    private void Update()
    {

        if(Vector2.Distance(waypoints[currentWaypintIndex].transform.position, transform.position) < .1f )
        {
            currentWaypintIndex++;
            if (currentWaypintIndex >= waypoints.Length)
            {
                currentWaypintIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypintIndex].transform.position, Time.deltaTime * speed);
    }
}
