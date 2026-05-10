using UnityEngine;

public class SpaceshipWeapon : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float bulletSpeed;

    void Update()
    {
        PrimaryWeapon();
    }

    void PrimaryWeapon()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("DISPARO");
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position = this.transform.localPosition;
            newBullet.GetComponent<Rigidbody>().AddForce(this.transform.forward * bulletSpeed);
        }
    }
}
