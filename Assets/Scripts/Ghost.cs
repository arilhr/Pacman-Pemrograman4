using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    private GhostType type;
    protected int cur;

    public GhostType Type
    {
        get { return type; }
        set { type = value; }
    }

    private void Update()
    {
        GhostMove();
    }

    public void GhostMove()
    {
        // Waypoint not reached yet? then move closer
        if (transform.position != type.Waypoints[cur])
        {
            Vector2 p = Vector2.MoveTowards(transform.position,
                                            type.Waypoints[cur],
                                            type.Speed);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }

        // Waypoint reached, select next one
        else cur = (cur + 1) % type.Waypoints.Length;
    }
}
