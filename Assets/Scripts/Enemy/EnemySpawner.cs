using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject player;
    public void Activate()
    {
        GameObject newEnemy = Instantiate(enemy);
        newEnemy.transform.position = this.transform.localPosition;
        newEnemy.GetComponent<EnemyMovement>().SetPlayer(player);
    }
    public void SetPlayer(GameObject player)
    {
        this.player = player;
    }
}
