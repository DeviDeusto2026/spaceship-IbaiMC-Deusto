
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerController : MonoBehaviour
{
    [SerializeField] private EnemySpawner[] spawnerList;
    [SerializeField] float timerMax = 5;
    [SerializeField] GameObject player;
    float timer;

    private void Start()
    {
        timer = timerMax;

        spawnerList = this.GetComponentsInChildren<EnemySpawner>();

        foreach (EnemySpawner enemySpawner in spawnerList)
        {
            enemySpawner.GetComponent<EnemySpawner>().SetPlayer(player);
        }
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = timerMax;
            SpawnEnemies();
        }
    }

    void SpawnEnemies()
    {
        foreach(EnemySpawner enemySpawner in spawnerList)
        {
            enemySpawner.Activate();
        }
    }
}
