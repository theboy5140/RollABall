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
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        rb.AddForce (movement * speed);
        string a = "瑟瑟发抖速度";
        Debug.Log (a);
    }
}