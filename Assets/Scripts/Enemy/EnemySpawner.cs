using UnityEngine;

public class EnemySpawner : MonoBehaviour
{ 
    [SerializeField] GameObject player;

    public void Activate(GameObject enemy)
    {
        GameObject newEnemy = Instantiate(enemy);
        newEnemy.transform.position = this.transform.localPosition;
        newEnemy.GetComponent<EnemyMovement>().SetPlayer(player);
    }
    
    public void ActivateElite(GameObject eliteEnemy)
    {
        GameObject newEnemy = Instantiate(eliteEnemy);
        newEnemy.transform.position = this.transform.localPosition;
        newEnemy.GetComponent<EliteEnemyMovement>().SetPlayer(player);
    }

    public void SetPlayer(GameObject player)
    {
        this.player = player;
    }
}
