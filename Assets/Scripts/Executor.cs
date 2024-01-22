using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Executor : MonoBehaviour
{
    [SerializeField] private UnityEvent _action;
    
    private readonly float _duration = 2f;
    private readonly int _repeatTimes = -1;
    private readonly LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        _action.Invoke();
    }

    public void Move()
    {
        Vector3 position = Vector3.up;
        transform.DOMove(position, _duration).SetLoops(_repeatTimes, _loopType).SetRelative(true);
    }

    public void Rotate()
    {
        Vector3 rotation = new(0, 0, 180);
        transform.DORotate(rotation, _duration).SetLoops(_repeatTimes, _loopType);
    }

    public void Scale()
    {
        Vector3 scale = new(5, 5, 5);
        transform.DOScale(scale, _duration).SetLoops(_repeatTimes, _loopType);
    }

    public void ChangeColor()
    {
        Color color = new(1, 0, 0);
        Material currentMaterial = GetComponent<MeshRenderer>().material;

        currentMaterial.DOColor(color, _duration).SetLoops(_repeatTimes, _loopType);
    }

    public void ChangeText()
    {
        string text = "Замена текста";
        Text currentText = GetComponent<Text>();
        Sequence sequence = DOTween.Sequence().SetLoops(_repeatTimes);

        sequence.Append(currentText.DOText(text, _duration))
            .Append(currentText.DOText(text, _duration).SetRelative(true))
            .Append(currentText.DOText(text, _duration, true, ScrambleMode.All));
    }
}
