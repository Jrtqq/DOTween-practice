using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Vector3 _newPosition = Vector3.up;

    private readonly float _duration = 2f;
    private readonly int _repeatTimes = -1;
    private readonly LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        transform.DOMove(_newPosition, _duration).SetLoops(_repeatTimes, _loopType).SetRelative(true);
    }
}
