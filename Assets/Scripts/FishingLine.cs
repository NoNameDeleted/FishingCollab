using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingLine : MonoBehaviour
{
    [SerializeField] private Transform _fishingRodPoint;
    [SerializeField] private Transform _hookPoint;
    [SerializeField] private Material _lineDefault;
    [SerializeField] private float _lineWidth = 0.02f;

    private LineRenderer _line;

    private void Awake()
    {
        _line = new GameObject("Line").AddComponent<LineRenderer>();
        _line.material = _lineDefault;
        _line.startColor = Color.grey;
        _line.endColor = Color.grey;
        _line.startWidth = _lineWidth;
        _line.endWidth = _lineWidth;
    }

    private void Update()
    {
        _line.SetPosition(0, _fishingRodPoint.position);
        _line.SetPosition(1, _hookPoint.position);
    }
}
