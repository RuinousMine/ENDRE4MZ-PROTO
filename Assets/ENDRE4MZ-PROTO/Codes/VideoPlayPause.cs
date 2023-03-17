using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Sprites;
using UnityEngine.UI;

public class VideoPlayPause : MonoBehaviour
{
    // Start is called before the first frame update

    private VideoPlayer player;
    public Button button;
    public Sprite startSprite;
    public Sprite stopSprite;

    void Start()
    {
        player = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void ChangeStartStop()
    {
        if (player.isPlaying == false)
        {
            player.Play();
            button.image.sprite = stopSprite;
        }
        else
        {
            player.Pause();
            button.image.sprite = startSprite;
        }
    }
}
