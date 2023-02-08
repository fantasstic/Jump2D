using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _jumpSpeed;
    [SerializeField] private GameObject _restartButton;

    
    private Rigidbody2D _rigidbody;
    private float _startHoldTime;
    private Animator _animator;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
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
        if(Input.GetMouseButtonDown(0))
        {
            _startHoldTime = Time.time;
        }

        if (Input.GetMouseButtonUp(0))
        {
            float relizeTime = Time.time;
            float jumpVelocity = _startHoldTime - relizeTime;
            _rigidbody.AddForce(new Vector2(-jumpVelocity * _jumpSpeed, _jumpForce));
            _animator.Play("Jump");
        }

        
    }
}
