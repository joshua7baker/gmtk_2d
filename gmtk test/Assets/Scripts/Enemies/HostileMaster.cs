using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostileMaster : MonoBehaviour
{
    public GameObject hostileRangedPrefab;
    public GameObject obstacleBoulderPrefab;

    public enum ObstacleTypes { hostileRanged, obstacleBoulder};
    public ObstacleTypes obstacleType;
    public bool isRandom;
    public bool isRanged;

    private EnemySelectionModel enemySelectionModel;

    void Start()
    {
        if (obstacleType == ObstacleTypes.hostileRanged)
        {
            Instantiate(hostileRangedPrefab, this.transform);
        }
        else if (obstacleType == ObstacleTypes.obstacleBoulder)
        {
            Instantiate(obstacleBoulderPrefab, this.transform);
        }
    }

    void Update()
    {
        
    }
}
