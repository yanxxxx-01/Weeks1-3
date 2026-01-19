using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class SpriteChnager : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public Sprite[] barrels;
    public int randomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.backspaceKey.wasPressedThisFrame)
        {
            PickARandomSprite();
        }

        //get the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is the mouse ver the sprite?
        //Y: set the colour to our col variable
        //N: set the colour to white
        if (spriteRenderer.bounds.Contains(mousePos) == true)
        {
            spriteRenderer.color = col;
        }
        else
        {
            spriteRenderer.color = Color.white;
        }

        if(Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count>0)
        {
            barrels.RemoveAt(0);
        }

    }
         
    void PiclRandomColor ()
    {   //when key pressed change sprite color to random color

        spriteRenderer.color = Random.ColorHSV();

    }
    
    void PickARandomSprite()
    {
        //Pick a random number between 1 and 3
        randomNumber = Random.Range(0, barrels.Count);
        //assign that sprite
        spriteRenderer.sprite = barrels[randomNumber];

    }




}
