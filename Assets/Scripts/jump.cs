using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] float jumpForce;
    private bool _isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, jumpForce);
            _isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground")) 
        { 
            _isGrounded = true;
        } 
    }
}

