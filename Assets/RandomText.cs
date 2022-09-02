using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomText : MonoBehaviour
{
    [SerializeField] Sprite [] characterTexts;
    [SerializeField] SpriteRenderer spriteRenderer;

    int randomNumber; 
    // Start is called before the first frame update
    void Start()
    {
        //ClickTheCharacter();   
    }

    // Update is called once per frame
    public void ClickTheCharacter()
    {
        randomNumber = Random.Range(1, characterTexts.Length + 1);
        spriteRenderer.sprite = characterTexts[randomNumber -1];
        print(randomNumber);
    }
}
