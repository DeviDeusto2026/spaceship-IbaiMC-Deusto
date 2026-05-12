using UnityEngine;

public class SpaceshipRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    
    void Update()
    {
        Rotation();
    }

    void Rotation()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.rotation *= Quaternion.Euler(0, -1 * rotationSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.rotation *= Quaternion.Euler(rotationSpeed * Time.deltaTime, 0 , 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.rotation *= Quaternion.Euler(-1 * rotationSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.rotation *= Quaternion.Euler(0, 0, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            this.transform.rotation *= Quaternion.Euler(0, 0, -1 * rotationSpeed * Time.deltaTime);
        }
    }
}
