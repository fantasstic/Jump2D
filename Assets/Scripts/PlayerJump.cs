using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private GameObject _restartButton;

    private bool _isGround;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger == true)
        {
            _restartButton.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            float velocityX = _rigidbody.velocity.x;
            float startTime = Time.time;
            velocityX = Time.time - startTime;
            _rigidbody.AddForce(new Vector2(velocityX, _jumpForce));
        }
    }

    /*private void Jump()
    {
        if (gameObject.tag == "Ground")
        {
            _isGround = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody.AddForce(new Vector2(_rigidbody.velocity.x, _jumpForce));
        }
    }*/
}
