using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CursorControl : MonoBehaviour
{
    private Texture normalTexture;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        normalTexture = AC.KickStarter.cursorManager.pointerIcon.texture;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;
        AC.KickStarter.cursorManager.pointerIcon.texture = normalTexture;
    }
}
