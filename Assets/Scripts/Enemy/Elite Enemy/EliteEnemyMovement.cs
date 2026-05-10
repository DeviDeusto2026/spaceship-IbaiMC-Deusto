using Unity.VisualScripting;
using UnityEngine;

public class EliteEnemyMovement : MonoBehaviour
{
    [SerializeField] float speed;
    public GameObject player;
    [SerializeField] float swingTimer;
    [SerializeField] float swingSpeed;
    float timer;


    public void SetPlayer(GameObject player)
    {
        this.player = player;
    }

    private void Start()
    {
        timer = swingTimer;
    }

    void Update()
    {
        transform.LookAt(player.transform);
        Movement();

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = swingTimer;
            swingSpeed *= -1;
        }
    }
    void Movement()
    {
        Vector3 direction = player.transform.position - this.transform.position;
        direction.Normalize();
        Vector3 position = direction * speed * Time.deltaTime;
        position.y += swingSpeed * Time.deltaTime;

        this.gameObject.transform.position += position;
    }
}
