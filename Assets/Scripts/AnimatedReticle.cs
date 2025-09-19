using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedReticle : MonoBehaviour {
    [SerializeField] private float rotateSpeed;
    [SerializeField] private GameObject reticle;
    
    private void Update() {
        this.reticle.transform.Rotate(this.rotateSpeed * Time.deltaTime * Vector3.up);
    }
}
