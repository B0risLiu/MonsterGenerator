using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GhostMove : MonoBehaviour
{
    [SerializeField] private float _spead;

    private Vector3 _targetPosition;

    private void Start()
    {
        SetNewTargetPosition();
    }

    private void Update()
    {
        if (transform.position == _targetPosition)
            SetNewTargetPosition();

        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _spead * Time.deltaTime);
    }

    private void SetNewTargetPosition()
    {
        const float RandomMinX = -20f;
        const float RandomMaxX = 20f;
        const float RandomMinY = -10f;
        const float RandomMaxY = 10f;
        _targetPosition = new Vector3(Random.Range(RandomMinX, RandomMaxX), Random.Range(RandomMinY, RandomMaxY), 0);
    }
}
