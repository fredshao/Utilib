using UnityEngine;

/// <summary>
/// 和层有关的一些Util方法
/// </summary>
public static class LayerUtil
{
    /// <summary>
    /// 开启摄像机某一层的渲染
    /// </summary>
    /// <param name="_cam"></param>
    /// <param name="_layer"></param>
    public static void SetRenderLayer(Camera _cam, int _layer)
    {
        if(_cam == null)
        {
            Debug.LogError("ERROR: Camera Can't be NULL");
            return;
        }

        _cam.cullingMask |= (1 << _layer);
    }

    /// <summary>
    /// 开启摄相机某一层的渲染
    /// </summary>
    /// <param name="_cam"></param>
    /// <param name="_layerName"></param>
    public static void SetRenderLayer(Camera _cam, string _layerName)
    {
        SetRenderLayer(_cam,LayerMask.NameToLayer(_layerName));
    }

    /// <summary>
    /// 关闭摄相机某一层的渲染
    /// </summary>
    /// <param name="_cam"></param>
    /// <param name="_layer"></param>
    public static void SetUnRenderLayer(Camera _cam, int _layer)
    {
        if(_cam == null)
        {
            Debug.LogError("ERROR: Camera Can't be NULL");
            return;
        }

        _cam.cullingMask &= ~(1 << _layer);
    }

    /// <summary>
    /// 关闭摄像机某一层的渲染
    /// </summary>
    /// <param name="_cam"></param>
    /// <param name="_layerName"></param>
    public static void SetUnRenderLayer(Camera _cam, string _layerName)
    {
        SetUnRenderLayer(_cam, LayerMask.NameToLayer(_layerName));
    }

    /// <summary>
    /// 某一层是否被渲染
    /// </summary>
    /// <param name="_cam"></param>
    /// <param name="_layer"></param>
    /// <returns></returns>
    public static bool IsRenderLayer(Camera _cam, int _layer)
    {
        if(_cam == null)
        {
            Debug.LogError("ERROR: Camera Can't be NULL");
            return false;
        }

        return (_cam.cullingMask & (1 << _layer)) != 0;
    }

    /// <summary>
    /// 某一层是否被渲染
    /// </summary>
    /// <param name="_cam"></param>
    /// <param name="_layerName"></param>
    /// <returns></returns>
    public static bool IsRenderLayer(Camera _cam, string _layerName)
    {
        return IsRenderLayer(_cam, LayerMask.NameToLayer(_layerName));
    }

    /// <summary>
    /// 设置一个GameObject为某一层，包括子物体，不管是 Active true 还是 Active false 的子物体
    /// </summary>
    /// <param name="_obj"></param>
    /// <param name="_layer"></param>
    public static void SetGameObjectToLayer(GameObject _obj, int _layer)
    {
        if(_obj == null)
        {
            Debug.LogError("ERROR: GameObject Can't be NULL");
            return;
        }

        _obj.layer = _layer;
        foreach(Transform child in _obj.transform)
        {
            SetGameObjectToLayer(child.gameObject, _layer);
        }
    }


    /// <summary>
    /// 设置一个GameObject为某一层，包括子物体，不管是 Active true 还是 Active false 的子物体
    /// </summary>
    /// <param name="_obj"></param>
    /// <param name="_layer"></param>
    public static void SetGameObjectToLayer(GameObject _obj, string _layerName)
    {
        SetGameObjectToLayer(_obj, LayerMask.NameToLayer(_layerName));
    }


}
