using UnityEngine;

public class EliteEnemyLife : MonoBehaviour
{
    [SerializeField] int lives;
    public EnemySpawnerController enemySpawnerController;
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.tag.Equals("Bullet")) return;

        Destroy(collision.gameObject);

        lives--;
        if (lives <= 0)
        {
            enemySpawnerController.eliteEnemyOnField = false;
            Destroy(this.gameObject);
        }
    }
}
