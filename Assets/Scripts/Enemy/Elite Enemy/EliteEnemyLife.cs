using UnityEngine;
using UnityEngine.SceneManagement;

public class EliteEnemyLife : MonoBehaviour
{
    [SerializeField] int lives;
    public EnemySpawnerController enemySpawnerController;
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.tag.Equals("Bullet")) return;

        lives--;
        if (lives <= 0)
        {
            enemySpawnerController.eliteEnemyOnField = false;
            SceneManager.LoadScene("Win");
            Destroy(this.gameObject);
        }
    }
}
