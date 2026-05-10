
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerController : MonoBehaviour
{
    [SerializeField] private EnemySpawner[] spawnerList;
    [SerializeField] float enemyCooldown = 5;
    [SerializeField] float eliteEnemyCooldown = 5;
    [SerializeField] GameObject player;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject eliteEnemy;

    public bool eliteEnemyOnField = false;
    private bool enemyInCooldown = false;
    private bool eliteEnemyInCooldown = true;


    private void Start()
    {
        eliteEnemy.GetComponent<EliteEnemyLife>().enemySpawnerController = this;

        spawnerList = this.GetComponentsInChildren<EnemySpawner>();

        foreach (EnemySpawner enemySpawner in spawnerList)
        {
            enemySpawner.GetComponent<EnemySpawner>().SetPlayer(player);
        }

        Invoke(nameof(AbilitateEliteEnemy), eliteEnemyCooldown);
    }

    void Update()
    {
        if (eliteEnemyOnField) return;

        TrySpawnEnemies();
        TrySpawnEliteEnemy();
    }

    void TrySpawnEnemies()
    {
        if (enemyInCooldown) return;

        SpawnEnemies();
        enemyInCooldown = true;
        Invoke(nameof(AbilitateEnemy), enemyCooldown);
    }
    void TrySpawnEliteEnemy()
    {
        if (eliteEnemyInCooldown) return;

        SpawnEliteEnemy();
        eliteEnemyInCooldown = true;
        Invoke(nameof(AbilitateEliteEnemy), eliteEnemyCooldown);
    }


    void SpawnEnemies()
    {
        foreach(EnemySpawner enemySpawner in spawnerList)
        {
            enemySpawner.Activate(enemy);
        }
    }

    void SpawnEliteEnemy()
    {
        int spawner = Random.Range(0, spawnerList.Length);

        spawnerList[spawner].ActivateElite(eliteEnemy);
        eliteEnemyOnField = true;
    }

    void AbilitateEnemy()
    {
        enemyInCooldown = false;
    }

    void AbilitateEliteEnemy()
    {
        eliteEnemyInCooldown = false;
    }
}
