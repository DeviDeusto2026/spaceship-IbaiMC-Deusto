using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] float lifeTime;
    public EnemySpawnerController enemySpawnerController;

    private void Start()
    {
        Invoke(nameof(Explode), lifeTime);
    }

    void Explode()
    {
        GameObject[] enemiesList = GameObject.FindGameObjectsWithTag("Enemy");

        foreach(GameObject enemy in enemiesList)
        {
            Destroy(enemy);
        }

        enemySpawnerController.eliteEnemyOnField = false;

        Destroy(this.gameObject);
    }

    public void SetEnemySpawnerController(EnemySpawnerController enemySpawnerController)
    {
        this.enemySpawnerController = enemySpawnerController;
    }
}
