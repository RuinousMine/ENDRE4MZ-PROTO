using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class ClickSound : MonoBehaviour
{

    void Update()
    {
         if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            GetComponent<AudioSource>().Play();
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
