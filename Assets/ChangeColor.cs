using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public SpriteRenderer Player;
    public SpriteRenderer Bullet;
    public Color32 Red;
    public Color32 Blue;
    public Color32 Yellow;

    public int colorVal;

    void Update()
    {
        ColorChange();
    }
    
    void ColorChange()
    {
        if (Input.GetMouseButtonDown(1))
        {
            colorVal += 1;
            if (colorVal == 1)
            {
                Player.color = Red;
            }
            else if (colorVal == 2)
            {
                Player.color = Blue;
            }
            else if(colorVal > 2)
            {
                colorVal = 0;
                Player.color = Yellow;
            }
            //Player.color = colors[colorVal];
            Bullet.color = Player.color;
        }
    }

}
