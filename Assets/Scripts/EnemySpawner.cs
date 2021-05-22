using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private GhostFactory ghostFactory;
    public float time;
    public Transform spawnPosition;

    private void Start()
    {
        ghostFactory = new GhostFactory();
        Invoke("SpawnRedGhost", 2f);
        Invoke("SpawnRedGhost", 5f);
    }

    private void SpawnRedGhost()
    {
        Instantiate(ghostFactory.GetGhost("RedGhost"), spawnPosition);
    }

    private void SpawnBlueGhost()
    {
        Instantiate(ghostFactory.GetGhost("BlueGhost"), spawnPosition);
    }


}
