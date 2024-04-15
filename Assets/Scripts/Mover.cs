using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1.5f;

    private readonly string Horizontal = nameof(Horizontal);

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButton(Horizontal))
        {
            Float();
        }
    }

    private void Float()
    {
        float direction = Input.GetAxis(Horizontal);
        float distance = direction * _moveSpeed;

        _rigidbody.velocity = new Vector2(distance, _rigidbody.velocity.y);
    }
}
