using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    public float ballSpeed = 2f;


    void Start()
    {
    //    Debug.Log("Calling the Start method"); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero; //initalize input vector W

        if(Input.GetKey(KeyCode.W))
        {
            inputVector +=Vector2.up;

        }

        
         if(Input.GetKey(KeyCode.A)) //A
        {
            inputVector +=Vector2.left;

        }

          if(Input.GetKey(KeyCode.S)) //S
        {
            inputVector += Vector2.down;

        }

          if(Input.GetKey(KeyCode.D)) //D
        {
           inputVector += Vector2.right;

        }
        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        Debug.Log("Resultant Vector: " + inputVector);
        Debug.Log("Resultant 3D Vector: " + inputVector);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);

        


    }
}
