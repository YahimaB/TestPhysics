using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseManager : MonoBehaviour
{
    [SerializeField] private int _targetFps;
    
    private void Awake()
    {
        Application.targetFrameRate = _targetFps;
    }
}
