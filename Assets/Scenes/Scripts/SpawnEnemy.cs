using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Transform _points;

    private Transform[] _spawnPoints;

    private void Start()
    {
        _spawnPoints = new Transform[_points.childCount];

        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            _spawnPoints[i] = _points.GetChild(i);
        }

        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var delay = new WaitForSeconds(2);

        for (int i = 0; i <= _spawnPoints.Length; i++)
        {
            if (i == _spawnPoints.Length)
            {
                i = 0;
            }

            Instantiate(_enemyPrefab, _spawnPoints[i].position, Quaternion.identity);
            yield return delay;
        }
    }
}
