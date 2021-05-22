using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ghost : MonoBehaviour
{
    protected string typeName;
    protected float speed;
    public Transform[] waypoints;
    protected int cur;

    protected void GhostMove()
    {
        // Waypoint not reached yet? then move closer
        if (transform.position != waypoints[cur].position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position,
                                            waypoints[cur].position,
                                            speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }

        // Waypoint reached, select next one
        else cur = (cur + 1) % waypoints.Length;
    }
}