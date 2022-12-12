using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MonsterMove : MonoBehaviour
{
    [SerializeField] private float _spead;

    private Transform _transform;
    private Vector3 _targetPosition;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        SetNewTargetPosition();
    }

    private void Update()
    {
        if (_transform.position == _targetPosition)
            SetNewTargetPosition();

        _transform.position = Vector3.MoveTowards(_transform.position, _targetPosition, _spead * Time.deltaTime);
    }

    private void SetNewTargetPosition()
    {
        const float RandomMinX = -21f;
        const float RandomMaxX = 21f;
        const float RandomMinY = -10f;
        const float RandomMaxY = 10f;
        _targetPosition = new Vector3(Random.Range(RandomMinX, RandomMaxX), Random.Range(RandomMinY, RandomMaxY), 0);
    }
}
