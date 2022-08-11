using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TextCore.Text;
using DG.Tweening;

[RequireComponent(typeof(TMP_Text))]
public class Glow : MonoBehaviour
{
    // private TextMeshPro _textMesh;
    private Material _material;
    private TMP_SDFShaderGUI tmpro;
    
    private void Start()
    {
        int ID_GlowPower = Shader.PropertyToID("_GlowPower");

        Debug.Log(TryGetComponent<TMP_Text>(out TMP_Text text) ? "TMP_text" : "tmpro ne ok");

        text.fontSharedMaterial.SetFloat(ShaderUtilities.ID_GlowPower, 0f);
        Tween tween = text.fontSharedMaterial.DOFloat(0.98f, ID_GlowPower, 0.5f).SetLoops(-1, LoopType.Yoyo);
    }
}
