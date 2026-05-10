using UnityEngine;

public class SpaceshipLife : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.tag.Equals("Enemy")) return;

        Die();
    }

    void Die()
    {
        Debug.Log("You die");
    }
}
