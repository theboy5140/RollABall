﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Text countText;
    public Text winText;

    private float speed = 10;
    private Rigidbody rb;
    private int count;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        winText.text = "";
        SetCountText ();
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        rb.AddForce (movement * speed);

    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag ("Pick Up")) {
            other.gameObject.SetActive (false);
            count += 1;
            SetCountText ();
        }
    }

    void SetCountText()
    {
        countText.text = "得分: " + count.ToString ();

        if (count >= 42) {
        
            winText.text = "花花你好吊";
        }
    }
}