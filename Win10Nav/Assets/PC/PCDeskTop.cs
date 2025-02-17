using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PCDeskTop : MonoBehaviour
{
    private Text _labTime;
    private void Awake()
    {
        _labTime=transform.Find("PanelTaskBar/LabTime").GetComponent<Text>();
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateTime();
        InvokeRepeating("UpdateTime", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void UpdateTime()
    {
        DateTime time = DateTime.Now;
        int year = time.Year;
        int month = time.Month;
        int day = time.Day;
        int hour = time.Hour;
        string hourStr = hour >= 10 ? hour.ToString() : "0" + hour;
        int minute = time.Minute;
        string minuteStr = minute >= 10 ? minute.ToString() : "0" + minute;
        int second = time.Second;
        string secondStr = second >= 10 ? second.ToString() : "0" + second;
        _labTime.text= hourStr + ":" + minuteStr + ":" + secondStr + "\n" + year + "/" + month + "/" + day;
    }
}
