using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private float speed = 10;

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        //float moveHorizontal = Input.GetAxis ("Horizontal");
        //float moveVertical = Input.GetAxis ("Vertical");
        if (Input.touchCount > 0 ) {
            
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            Vector3 movement = new Vector3 (touchDeltaPosition.x, 0.0f, touchDeltaPosition.y);

            rb.AddForce (movement * speed);
        }
  
    }
}