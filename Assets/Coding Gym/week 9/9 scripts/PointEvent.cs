using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointEvent : MonoBehaviour
{
    public Image bread;
    public Sprite burger;
    public Sprite defaultSprite;
    public GameObject prefab;
    public void MouseEnter()
    {
        bread.sprite = burger;
    }

    public void MouseExit()
    {
        bread.sprite = defaultSprite;
    }

    public void MouseClick() 
    {
        Instantiate(prefab);
    }
}
