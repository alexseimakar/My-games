using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Map_controller : MonoBehaviour
{
    public List<GameObject> terrainChunks;
    public GameObject player;
    public float checkerRadius;
    Vector3 noTerrainPos;
    public LayerMask terrainMask;
    Player_movement pm;

    
    void Start()
    {
        pm = FindAnyObjectByType<Player_movement>();
    }

    // Update is called once per frame
    void Update()
    {
        ChunkChecker();
    }

    void ChunkChecker()
    {
        if (pm.moveDir.x > 0 && pm.moveDir.y == 0)
        {
            if (!Physics2D.OverlapCircle(player.transform.position + new Vector3(16, 0, 0), checkerRadius, terrainMask))
            {
                noTerrainPos = player.transform.position + new Vector3(16, 0 ,0);
                SpawnChunk();
            }
        }
    }

    void SpawnChunk()
    {
        int rand = Random.Range(0, terrainChunks.Count);
        Instantiate(terrainChunks[rand], noTerrainPos, Quaternion.identity);
    }
}
