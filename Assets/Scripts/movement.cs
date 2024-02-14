using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _directionX;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _directionX = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(_directionX * speed, _rb.velocity.y);
    }
}
