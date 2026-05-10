using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject player;
    
    void Update()
    {
        transform.LookAt(player.transform);
        Movement();
    }

    void Movement()
    {
        Vector3 direction = player.transform.position - this.transform.position;
        this.gameObject.transform.position += direction * speed * Time.deltaTime;
    }
}
