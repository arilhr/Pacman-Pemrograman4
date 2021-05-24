using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostFactory : ScriptableObject
{

    public GhostType GetGhost(string typeName)
    {
        switch (typeName)
        {
            case "RedGhost":
                RedGhost redGhost = new RedGhost();
                redGhost.SetGhost();
                return redGhost;
            case "BlueGhost":
                BlueGhost blueGhost = new BlueGhost();
                blueGhost.SetGhost();
                return blueGhost;
            default:
                return null;
        }
    }
}
