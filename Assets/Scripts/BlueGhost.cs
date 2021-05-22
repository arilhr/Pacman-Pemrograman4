using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueGhost : Ghost
{
    // Start is called before the first frame update
    void Start()
    {
        typeName = "Blue Ghost";
        speed = 0.03f;
    }

    private void FixedUpdate()
    {
        GhostMove();
    }
}
