using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldTimer : MonoBehaviour
{
    float countTime = 0;
    // Update is called once per frame
    void Start()
    {
        countTime += Time.deltaTime;

        GetComponent<Text>().text = countTime.ToString("F2");
    }
}
