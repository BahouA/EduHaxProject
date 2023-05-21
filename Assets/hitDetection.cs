using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitDetection : MonoBehaviour
{
    public Sprite gold;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (spriteRenderer != null && gold != null && Input.GetMouseButtonDown(0))
        {
            // Replace the sprite with the new sprite
            spriteRenderer.sprite = gold;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                if (spriteRenderer != null)
                {
                    // Change the sprite in the SpriteRenderer
                    spriteRenderer.sprite = gold;
                }
            }
        }
    }
}
