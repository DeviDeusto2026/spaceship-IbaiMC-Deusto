using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    [SerializeField] int lives;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.tag.Equals("Bullet")) return;

        lives--;
        if (lives <= 0) Destroy(this.gameObject);
    }
}
