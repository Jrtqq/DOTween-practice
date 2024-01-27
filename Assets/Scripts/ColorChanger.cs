using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Material _material;
    private Color _newColor = new(1, 0, 0);

    private readonly float _duration = 2f;
    private readonly int _repeatTimes = -1;
    private readonly LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        _material = GetComponent<MeshRenderer>().material;

        _material.DOColor(_newColor, _duration).SetLoops(_repeatTimes, _loopType);
    }
}
