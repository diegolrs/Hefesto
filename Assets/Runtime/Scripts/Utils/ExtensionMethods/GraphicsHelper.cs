using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class GraphicsHelper
{
    public static void SetAlpha(this UnityEngine.UI.Graphic g, float value)
    {
        Color color = g.color;
        color.a = Mathf.Clamp01(value);
        g.color = color;
    }

    public static void SetAlpha(this SpriteRenderer r, float value)
    {
        Color color = r.color;
        color.a = Mathf.Clamp01(value);
        r.color = color;
    }

    public static void SetColor(this CanvasGroup cg, Color color)
    {
        foreach(Graphic g in cg.GetComponentsInChildren<Graphic>())
            g.color = color;
    }
}
