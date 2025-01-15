using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed;
    [SerializeField] private float jumpHeight;

    private bool plane;

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

      public void Jump() 
      //useing force mode to add the jump: https://docs.unity3d.com/ScriptReference/ForceMode.html
      //of the 4 force mode properties - using impulse to have the instant jump reaction: https://docs.unity3d.com/ScriptReference/ForceMode.Impulse.html
      
    {
        if(plane)
        {
        sphereRigidbody.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
                

        plane = false;

        }
    }

    private void OnCollisionEnter(Collision c)
    // detecting if the sphere is on the plane: https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter.html
    {
        if(c.gameObject.name == "Plane")
        {
            plane = true;
        }
    }
}

