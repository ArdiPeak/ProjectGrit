using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDisplay : MonoBehaviour
{
    public EnemyTemplate enemyData;

    public SpriteRenderer enemySprite;

    // Start is called before the first frame update
    void Start()
    {
        enemySprite.sprite = enemyData.enemyImg;

    }

}
