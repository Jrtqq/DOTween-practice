using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Text))]

public class TextChanger : MonoBehaviour
{
    private Text _text;
    private string _newText = "Замена текста";

    private readonly float _duration = 2f;
    private readonly int _repeatTimes = -1;

    private void Start()
    {
        _text = GetComponent<Text>();

        Sequence sequence = DOTween.Sequence().SetLoops(_repeatTimes);

        sequence.Append(_text.DOText(_newText, _duration))
            .Append(_text.DOText(_newText, _duration).SetRelative(true))
            .Append(_text.DOText(_newText, _duration, true, ScrambleMode.All));
    }
}
