using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float enemyOffset;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.tag.Equals("Bullet")) return;

        float[] spawnPoints = {0, 90, 180, 270};

        foreach(int position in spawnPoints)
        {
            SpawnEnemy(position * enemyOffset);
        }
    }

    void SpawnEnemy(float angle)
    {
        GameObject newEnemy = Instantiate(enemy);

        Vector3 position = this.transform.position + new Vector3(0, 0, enemyOffset);
        newEnemy.GetComponent<EnemyMovement>().SetPlayer(this.GetComponent<EliteEnemyMovement>().player);

        newEnemy.transform.position = position;
        newEnemy.gameObject.transform.RotateAround(this.transform.position, Vector3.up, angle);      
    }
}
