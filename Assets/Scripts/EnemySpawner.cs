using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] ghost;
    public Transform spawnPos;
    private GhostFactory ghostFactory;


    private void Start()
    {
        ghostFactory = new GhostFactory();
        Invoke("SpawnRedGhost", 2);
        Invoke("SpawnBlueGhost", 10);
    }

    private void SpawnRedGhost()
    {
        var ghostObject = Instantiate(ghost[0], spawnPos.position, Quaternion.identity);
        Ghost g = ghostObject.GetComponent<Ghost>();
        g.Type = ghostFactory.GetGhost("RedGhost");
    }

    private void SpawnBlueGhost()
    {
        var ghostObject = Instantiate(ghost[1], spawnPos.position, Quaternion.identity);
        Ghost g = ghostObject.GetComponent<Ghost>();
        g.Type = ghostFactory.GetGhost("BlueGhost");
    }
}
