using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    private Vector3 _newScale = new(5, 5, 5);

    private readonly float _duration = 2f;
    private readonly int _repeatTimes = -1;
    private readonly LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        transform.DOScale(_newScale, _duration).SetLoops(_repeatTimes, _loopType);
    }
}
