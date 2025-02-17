using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : SingletonTemplate<GameManager>
{
    [DllImport("__Internal")]
    private static extern bool IsPhone();
    [DllImport("__Internal")]
    private static extern bool Printf(string msg);
    private void Start()
    {
#if UNITY_EDITOR
        SceneManager.LoadScene("PC");
#else
        if (IsPhone())
        {
            SceneManager.LoadScene("Mobile");
            Info("�ƶ�ģʽ");
        }
        else
        {
            SceneManager.LoadScene("PC");
            Info("PCģʽ");
        }
#endif

    }
    public void Info(string info)
    {
        Printf(info);
    }
}
