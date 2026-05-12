using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float lifeTime;

    void Start()
    {
        Destroy(this.gameObject, lifeTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
