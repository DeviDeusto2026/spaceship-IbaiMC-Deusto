using UnityEngine;
using UnityEngine.SceneManagement;

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
            if (enemy.name.Equals("EliteEnemy(Clone)")) SceneManager.LoadScene("Win");
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
