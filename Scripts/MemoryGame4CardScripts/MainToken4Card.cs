using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainToken4Card : MonoBehaviour
{
    GameObject gameControl;
    SpriteRenderer spriteRenderer;
    public Sprite[] faces;
    public Sprite back;
    public int faceIndex;
    public bool matched;


    public void OnMouseDown()
    {
        if (matched == false)
        {
            if (spriteRenderer.sprite == back)
            {
                if (gameControl.GetComponent<GameControl4Card>().TwoCardsUp() == false)
                {
                    spriteRenderer.sprite = faces[faceIndex++];
                    gameControl.GetComponent<GameControl4Card>().AddVisibleFace(faceIndex);
                    matched = gameControl.GetComponent<GameControl4Card>().CheckMatch();
                }

            }
            else
            {
                spriteRenderer.sprite = back;
                gameControl.GetComponent<GameControl4Card>().RemoveVisibleFace(faceIndex);
            }
        }
 
    }

    private void Awake()
    {
        gameControl = GameObject.Find("GameControl4Card");
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
