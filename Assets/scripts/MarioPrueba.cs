using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioPrueba : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D _rigidbody;
    public float jumpForce = 10f;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float inputHorizontal = Input.GetAxisRaw("Horizontal");  
        _rigidbody.velocity = new Vector2(inputHorizontal * speed, _rigidbody.velocity.y);

          if (Input.GetButtonDown("Jump"))
        {
            _rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        
        if(inputHorizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if(inputHorizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0,180,0);
        }
    }
}