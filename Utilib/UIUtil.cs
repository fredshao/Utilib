using UnityEngine;

/// <summary>
/// 和UI有关的一些Util方法
/// </summary>
public static class UIUtil
{
    /// <summary>
    /// 锚点左边
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void AnchorsLeft(RectTransform _rectTrans)
    {
        _rectTrans.anchorMin = new Vector2(0, 0.5f);
        _rectTrans.anchorMax = new Vector2(0, 0.5f);
    }

    /// <summary>
    /// 锚点右边
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void AnchorsRight(RectTransform _rectTrans)
    {
        _rectTrans.anchorMin = new Vector2(1, 0.5f);
        _rectTrans.anchorMax = new Vector2(1, 0.5f);
    }

    /// <summary>
    /// 锚点上面
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void AnchorsTop(RectTransform _rectTrans)
    {
        _rectTrans.anchorMin = new Vector2(0.5f,1);
        _rectTrans.anchorMax = new Vector2(0.5f,1);
    }

    /// <summary>
    /// 锚点下面
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void AnchorsBottom(RectTransform _rectTrans)
    {
        _rectTrans.anchorMin = new Vector2(0.5f, 0);
        _rectTrans.anchorMax = new Vector2(0.5f, 0);
    }

    /// <summary>
    /// 锚点左上
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void AnchorsLeftTop(RectTransform _rectTrans)
    {
        _rectTrans.anchorMin = new Vector2(0, 1);
        _rectTrans.anchorMax = new Vector2(0, 1);
    }

    /// <summary>
    /// 锚点左下
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void AnchorsLeftBottom(RectTransform _rectTrans)
    {
        _rectTrans.anchorMin = new Vector2(0, 0);
        _rectTrans.anchorMax = new Vector2(0, 0);
    }

    /// <summary>
    /// 锚点右上
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void AnchorsRightTop(RectTransform _rectTrans)
    {
        _rectTrans.anchorMin = new Vector2(1, 1);
        _rectTrans.anchorMax = new Vector2(1, 1);
    }

    /// <summary>
    /// 锚点右下
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void AnchorsRightBottom(RectTransform _rectTrans)
    {
        _rectTrans.anchorMin = new Vector2(1, 0);
        _rectTrans.anchorMax = new Vector2(1, 0);
    }

    /// <summary>
    /// 锚点中心
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void AnchorsCenter(RectTransform _rectTrans)
    {
        _rectTrans.anchorMin = new Vector2(0.5f, 0.5f);
        _rectTrans.anchorMax = new Vector2(0.5f, 0.5f);
    }


    /// <summary>
    /// 向左拉伸
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void StretchLeft(RectTransform _rectTrans)
    {
        _rectTrans.pivot = new Vector2(1, 0.5f);
    }

    /// <summary>
    /// 向右拉伸
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void StretchRight(RectTransform _rectTrans)
    {
        _rectTrans.pivot = new Vector2(0, 0.5f);
    }

    /// <summary>
    /// 向上拉伸
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void StretchUp(RectTransform _rectTrans)
    {
        _rectTrans.pivot = new Vector2(0.5f,0);
    }

    /// <summary>
    /// 向下拉伸
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void StretchDown(RectTransform _rectTrans)
    {
        _rectTrans.pivot = new Vector2(1, 0.5f);
    }

    /// <summary>
    /// 向左下拉伸
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void StretchLeftDown(RectTransform _rectTrans)
    {
        _rectTrans.pivot = new Vector2(1,1);
    }

    /// <summary>
    /// 向左上拉伸
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void StretchLeftUp(RectTransform _rectTrans)
    {
        _rectTrans.pivot = new Vector2(1, 0);
    }

    /// <summary>
    /// 向右上拉但
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void StretchRightUp(RectTransform _rectTrans)
    {
        _rectTrans.pivot = new Vector2(0,0);
    }

    /// <summary>
    /// 向右下拉伸
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void StretchRightDown(RectTransform _rectTrans)
    {
        _rectTrans.pivot = new Vector2(0,1);
    }

    /// <summary>
    /// 左右拉伸
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void StretchLeftRight(RectTransform _rectTrans)
    {
        _rectTrans.pivot = new Vector2(0.5f, 0.5f);
    }

    /// <summary>
    /// 上下拉伸
    /// </summary>
    /// <param name="_rectTrans"></param>
    public static void StretchUpDown(RectTransform _rectTrans)
    {
        _rectTrans.pivot = new Vector2(0.5f, 0.5f);
    }
}
