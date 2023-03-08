using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;

public class GameManager : MonoBehaviour
{
    [SerializeField] 
    private GameObject redZombie, blueZombie, greenZombie;

    
    // Start is called before the first frame update
    void Start()
    {
        SpawnTarget();
    }

    public void SpawnTarget()
    {
        float spawnPointX = 0.0f;
        float spawnPointZ = 0.0f;
        Vector3 spawnPosition = new Vector3(spawnPointX, 0.0f, spawnPointZ);

        Instantiate(redZombie, spawnPosition, Quaternion.identity);
        Instantiate(blueZombie, spawnPosition, Quaternion.identity);
        Instantiate(greenZombie, spawnPosition, Quaternion.identity);
    }
    
}
