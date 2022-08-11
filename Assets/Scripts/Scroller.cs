using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Scroller : MonoBehaviour
{
    [SerializeField] private RawImage _image;
    [SerializeField] private float _x, _y;
    private Color[] _colors = new[] {Color.blue, Color.green, Color.magenta, Color.cyan, Color.yellow, Color.white};
    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.SetDelay(13.4f, false);
        
        for (int i = 0; i < _colors.Length; i++)
        {
            sequence.Append(_image.DOColor(_colors[i], 0.5f));
        }
        
        sequence.SetEase(Ease.Linear).SetLoops(-1);
    }

    private void Update()
    {
        _image.uvRect = new Rect(_image.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, _image.uvRect.size);
    }
}
