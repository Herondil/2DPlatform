using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]
    private float JumpForce;

    Rigidbody2D rgbd;
    bool jumpKeyPressed;

    private void Awake()
    {
        rgbd = GetComponent<Rigidbody2D>();
        jumpKeyPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Jump key pressed");
            jumpKeyPressed = true;
        }
    }

    private void FixedUpdate()
    {
        if (jumpKeyPressed)
        {
            rgbd.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            jumpKeyPressed=false;
        }
    }
}
