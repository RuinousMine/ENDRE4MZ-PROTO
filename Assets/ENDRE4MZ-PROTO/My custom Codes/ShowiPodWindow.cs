using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowiPodWindow : MonoBehaviour
{
    public GameObject iPodWindow;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            iPodWindow.SetActive(true);
            Debug.Log("Its Working");
        }
    }
}
