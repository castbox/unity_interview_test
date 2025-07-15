using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


public enum RollingAxis
{
    X,
    Y,
    Z
}


/// <summary>
/// 滚动平面控制器
/// </summary>
public class RollingPlaneController : MonoBehaviour
{

    // 可选的滚动轴，运行时通过调整此参数，改变平面卷曲的轴向
    public RollingAxis rollAxis;


    private void Awake()
    {
        //TODO: 请开始编写你的逻辑
    }
}
