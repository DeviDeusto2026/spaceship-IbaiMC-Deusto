using UnityEngine;

public class EliteEnemyWeapon : MonoBehaviour
{

    [SerializeField] float shootCooldown = 5;
    [SerializeField] GameObject bullet;
    float bulletSpeed = 2000;
    bool shootInCooldown = true;
    float bulletOffset = 10;

    void Start()
    {
        Invoke(nameof(AbilitateShoot), shootCooldown);
    }

    void Update()
    {
        TryShoot();
    }

    void TryShoot()
    {
        if (shootInCooldown) return;

        Shoot();
        shootInCooldown = true;
        Invoke(nameof(AbilitateShoot), shootCooldown);
    }

    void Shoot()
    {
        GameObject newBullet = Instantiate(bullet);
        newBullet.transform.position = this.transform.localPosition;
        newBullet.transform.position += this.transform.forward * bulletOffset;
        newBullet.GetComponent<Rigidbody>().AddForce(this.transform.forward * bulletSpeed);
    }

    void AbilitateShoot()
    {
        shootInCooldown = false;
    }
}
