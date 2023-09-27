using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 0.05f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -_speed);
    }
}
