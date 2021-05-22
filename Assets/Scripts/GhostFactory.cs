using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostFactory : MonoBehaviour
{
    public GameObject GetGhost(string typeName)
    {
        var ghost = Resources.Load(typeName) as GameObject;
        if (ghost != null)
        {
            return ghost;
        }
        else
        {
            return null;
        }
    }
}
