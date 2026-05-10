using UnityEngine;

public class SpaceshipWeapon : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float bulletSpeed;
    [SerializeField] GameObject bomb;
    [SerializeField] float bombSpeed;
    [SerializeField] int bombNumber;
    [SerializeField] EnemySpawnerController enemySpawnerController;

    void Update()
    {
        PrimaryWeapon();
        SecondWeapon();
    }

    void PrimaryWeapon()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position = this.transform.localPosition;
            newBullet.GetComponent<Rigidbody>().AddForce(this.transform.forward * bulletSpeed);
        }
    }

    void SecondWeapon()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && bombNumber>0)
        {
            GameObject newBomb = Instantiate(bomb);
            newBomb.transform.position = this.transform.localPosition;
            newBomb.GetComponent<Rigidbody>().AddForce(this.transform.forward * bombSpeed);
            newBomb.GetComponent<Bomb>().SetEnemySpawnerController(enemySpawnerController);
            bombNumber--;
        }
    }
}
