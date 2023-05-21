using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameHandler : MonoBehaviour
{
    public Sprite goldSprite;

    private SpriteRenderer spriteRenderer;

    AudioSource aud;

    bool flag = true;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        aud = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {

    }

    private void OnMouseDown()
    {
        spriteRenderer.sprite = goldSprite;
        if (flag)
        {
            aud.Play();
            flag = false;
        }
    }

}
