using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour {

    void Update () {
        transform.Translate(5f * Time.deltaTime, 0f, 0f);
    }
}