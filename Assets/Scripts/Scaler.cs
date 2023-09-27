using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _sacleFactor = 0.001f;
    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(_sacleFactor, _sacleFactor, _sacleFactor);
    }
}
