using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    [SerializeField] private Boat _boat;
    [SerializeField] private float _speed = 0.02f;
    [SerializeField] private Vector2 _deep = new Vector2(-0.37f, 1);
    [SerializeField] private float _maxDeep = 3f;

    private readonly string Vertical = nameof(Vertical);

    private void Update()
    {
        MoveTowards(_boat.transform.position);

        if (Input.GetButton(Vertical))
        {
            ReelUp();
        }
    }

    private void MoveTowards(Vector2 targetPoint)
    {
        transform.position = Vector2.Lerp(transform.position, targetPoint - _deep, _speed);
    }

    private void ReelUp()
    {
        float direction = Input.GetAxis(Vertical);

        _deep.y = Mathf.Clamp(_deep.y - direction * _speed, 0, _maxDeep);
    }
}
