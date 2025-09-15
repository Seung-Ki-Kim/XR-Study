using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentTimeController : MonoBehaviour {
    private DateTime currentDataTime;
    private int currentTimeHour;
    private int currentTimeMin;
    private int currentTimeSec;

    [SerializeField] private GameObject hourObj;
    [SerializeField] private GameObject minObj;
    [SerializeField] private GameObject secObj;
    
    
    private void Init() {
        this.currentDataTime = DateTime.Now;
    }

    private void Awake() {
        Init();
    }
    
    private void Update() {
        this.currentDataTime = DateTime.Now;
        this.currentTimeHour = this.currentDataTime.Hour;
        this.currentTimeMin = this.currentDataTime.Minute;
        this.currentTimeSec = this.currentDataTime.Second;
        
        /*
         * - Data = 24h / 360도 / 12칸
         * 5칸 (5분) = 30도
         * 1칸 (1분) = 6도
         *
         * - 14시 47분 35초
         * 시: (15 - 12) * 30 
         * 분: 47 * 6
         * 초: 35 * 6
         */

        this.hourObj.transform.rotation = Quaternion.Euler((this.currentTimeHour - 12) * 30, 180, 0);
        this.minObj.transform.rotation = Quaternion.Euler((this.currentTimeMin) * 6, 180, 0);
        this.secObj.transform.rotation = Quaternion.Euler((this.currentTimeSec) * 6, 180, 0);
    }
}