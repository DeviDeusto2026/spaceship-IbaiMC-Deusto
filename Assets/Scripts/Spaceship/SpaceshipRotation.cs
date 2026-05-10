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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.rotation *= Quaternion.Euler(0, -1 * rotationSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.rotation *= Quaternion.Euler(rotationSpeed * Time.deltaTime, 0 , 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.rotation *= Quaternion.Euler(-1 * rotationSpeed * Time.deltaTime, 0, 0);
        }


    }
}
