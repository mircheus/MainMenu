using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TextCore.Text;

public class Glow : MonoBehaviour
{
    // private TextMeshPro _textMesh;
    private Material _material;

    private int ID_GlowPower = Shader.PropertyToID("_GlowPower");

    private void Start()
    {
        if(TryGetComponent<TextMeshPro>(out TextMeshPro textMeshPro))
        {
            Debug.Log("OK");
        }
        else
        {
            Debug.Log("ne ok");
        }

        //_textMesh.fontSharedMaterial.SetFloat(ShaderUtilities.ID_GlowPower, 1.0f);
        //StartCoroutine(GlowFader());s
    }

    private IEnumerator GlowFader()
    {
        var waitFor = new WaitForSeconds(0.5f);
        float glowDelta = 0.1f;
        float currentValue = 0f;
        int k = 0;
        // while (_textMesh.fontSharedMaterial.GetFloat(ShaderUtilities.ID_GlowPower) !> 0.9f)
        while (k != 10)
        {
            k++;
            currentValue += glowDelta;
            //_textMesh.fontSharedMaterial.SetFloat(ShaderUtilities.ID_GlowPower, currentValue);
            yield return waitFor;
        }
    }
}
