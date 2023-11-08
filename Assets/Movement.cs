using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rgbdref;
    private Vector2 dir;
    public float speed;

    private void Awake()
    {
        rgbdref = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        dir = new Vector2(horizontal, 0).normalized;

        Debug.DrawLine(rgbdref.position, dir*5, Color.red);

        
        if(dir.x < 0)
        {
            transform.localScale = new Vector3(-1, 1,1);
        }

        if (dir.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

    }

    private void FixedUpdate()
    {
        Vector2 d = new Vector2(dir.x, rgbdref.velocity.y).normalized;
        Vector2 t = d*speed;
        t.y = rgbdref.velocity.y;
        rgbdref.velocity = t;
    }
}
