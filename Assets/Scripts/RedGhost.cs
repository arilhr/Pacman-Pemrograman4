using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGhost : GhostType
{
    public void SetGhost()
    {
        ghostName = "Redy";
        speed = 0.05f;
        waypoints = new Vector3[] {
            new Vector3(1f, 2f, 0f),
            new Vector3(-1, 2, 0),
            new Vector3(-1, -4, 0),
            new Vector3(-3, -4, 0),
            new Vector3(-3, -2, 0),
            new Vector3(-6, -2, 0),
            new Vector3(-6, 4, 0),
            new Vector3(-4, 4, 0),
            new Vector3(-4, 2, 0),
            new Vector3(-1, 2, 0),
            new Vector3(-1, 4, 0),
            new Vector3(5, 4, 0),
            new Vector3(5, 0, 0),
            new Vector3(3, 0, 0),
            new Vector3(3, 2, 0)
        };
    }
}
