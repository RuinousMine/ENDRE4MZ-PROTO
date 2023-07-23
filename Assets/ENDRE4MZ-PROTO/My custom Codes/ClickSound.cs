using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class ClickSound : MonoBehaviour
{

    void Update()
    {
         if(Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
