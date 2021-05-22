using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGhost : Ghost
{
    private void Start()
    {
        typeName = "Red Ghost";
        speed = 0.05f;
    }

    private void FixedUpdate()
    {
        GhostMove();
    }
}
