using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        movement(); 
    }

    void movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += this.transform.forward * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += -1 * this.transform.forward * speed * Time.deltaTime;
        }
        
    }
}
