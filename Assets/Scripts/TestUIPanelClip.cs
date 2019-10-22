using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUIPanelClip : MonoBehaviour
{
    public Renderer mRenderer;
    public UIWidget mUIWidget;

    private void Awake()
    {
        
    }

    private void Start()
    {
        if (mRenderer && mRenderer.sharedMaterial)
        {
            Vector3 localPos = transform.localPosition;
            Vector2 size = new Vector2(mUIWidget.width, mUIWidget.height);
            size *= 0.5f;
            Vector4 clipRange = new Vector4(-localPos.x / size.x, -localPos.y / size.y, 1f / size.x, 1f / size.y);
            mRenderer.sharedMaterial.SetVector("_ClipRange0", clipRange);
            mRenderer.sharedMaterial.SetFloat("_EnableClip", 1);
            mRenderer.sharedMaterial.SetVector("_EffectScale", new Vector2(420, 30));
        }
    }

    private void OnDisable()
    {
        if (mRenderer && mRenderer.sharedMaterial)
        {
            mRenderer.sharedMaterial.SetFloat("_EnableClip", 0);
        }
    }
}
