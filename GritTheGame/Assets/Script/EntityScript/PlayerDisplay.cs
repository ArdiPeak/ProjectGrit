using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisplay : MonoBehaviour
{
    public PlayerTemplate playerData;

    public SpriteRenderer playerSprite;

    // Start is called before the first frame update
    void Start()
    {
        playerSprite.sprite = playerData.playerImg;

    }

}
