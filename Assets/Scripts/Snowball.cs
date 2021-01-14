using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour
{
    [SerializeField] GameObject _snowball;
    [SerializeField] Transform _spawnPos;

    public void Fire()
    {
        Instantiate(_snowball, _spawnPos.position, _spawnPos.rotation);
        Destroy(_snowball, 4);
    }
}
