using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceshipLife : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.tag.Equals("Enemy")) return;

        Die();
    }

    void Die()
    {
        SceneManager.LoadScene("Lose");
    }
}
