﻿using System;
#if UNITY_2017
using UnityEngine;
#endif

namespace LCY
{
    /// <summary>
    /// Universal Debug class that logs debug information
    /// </summary>
    static public class UDebug
    {
        static public void Log(string s)
        {
            //Debug.Log(s);
        }

        static public void LogException(Exception e)
        {
            //Debug.LogException(e);
        }
    }
}