using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _template;
    [SerializeField] private int _count;
    [SerializeField] private float _pause;
    [SerializeField] private Transform _spawnPoints;

    private Transform[] _points;

    private void Start()
    {
        _points = new Transform[_spawnPoints.childCount];

        for (int i = 0; i < _spawnPoints.childCount; i++)
        {
            _points[i] = _spawnPoints.GetChild(i).transform;
        }

        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var pause = new WaitForSeconds(_pause);

        for (int i = 0; i < _count; i++)
        {
            var transform = _points[Random.Range(0, _points.Length)];
            Instantiate(_template, transform.position, Quaternion.identity);
            yield return pause;
        }
    }
}
