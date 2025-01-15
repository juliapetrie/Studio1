using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed;
    [SerializeField] private float jumpHeight;

    private bool plane;
    
     void Start() //might not need this
    {
        plane = true;
    }

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

      public void Jump() //add citation
    {
        if(plane)
        {
        sphereRigidbody.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        plane = false;

        }
    }

    private void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.name == "Plane")
        {
            plane = true;
        }
    }
}

