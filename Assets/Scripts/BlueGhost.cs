using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueGhost : GhostType
{
    public void SetGhost()
    {
        ghostName = "Bluewy";
        speed = 0.03f;
        waypoints = new Vector3[] {
            new Vector3(1f, 2f, 0f),
            new Vector3(-1, 2, 0),
            new Vector3(-1, 4, 0),
            new Vector3(5, 4, 0),
            new Vector3(5, 0, 0),
            new Vector3(3, 0, 0),
            new Vector3(3, -4, 0),
            new Vector3(7, -4, 0),
            new Vector3(7, -1, 0),
            new Vector3(8, -1, 0),
            new Vector3(8, 1, 0),
            new Vector3(5, 1, 0),
            new Vector3(5, 4, 0),
            new Vector3(-1, 4, 0),
            new Vector3(-1, 2, 0)
        };
    }
}
