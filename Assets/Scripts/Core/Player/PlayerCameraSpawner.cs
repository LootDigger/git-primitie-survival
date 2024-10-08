using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cameraPrefab;
    private void Start() => Instantiate(_cameraPrefab).GetComponent<CameraFollow>().SetTarget(transform);
}
