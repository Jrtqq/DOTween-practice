using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Vector3 _newRotation = new(0, 0, 180);

    private readonly float _duration = 2f;
    private readonly int _repeatTimes = -1;
    private readonly LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        transform.DORotate(_newRotation, _duration).SetLoops(_repeatTimes, _loopType);
    }
}
