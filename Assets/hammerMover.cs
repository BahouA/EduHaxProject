using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerMover : MonoBehaviour
{
    Animator hammerAnim;
    public Texture2D hammerMove;

    // Start is called before the first frame update
    void Start()
    {
        hammerAnim = gameObject.GetComponent<Animator>();
        Cursor.SetCursor(hammerMove, Vector2.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.Set(mousePosition.x + 0.47f, mousePosition.y + 0.7f);
        transform.position = Vector2.MoveTowards(transform.position, mousePosition, 100 * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            hammerAnim.SetTrigger("Active");
        }
    }
}
