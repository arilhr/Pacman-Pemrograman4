using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GhostType
{
    protected string ghostName;
    protected float speed;
    protected Vector3[] waypoints;

    public float Speed
    {
        get { return speed; }
    }

    public string GhostName
    {
        get { return ghostName; }
    }

    public Vector3[] Waypoints
    {
        get { return waypoints; }
    }
}
