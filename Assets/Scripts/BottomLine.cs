using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D target)
    {
        StickerController.health -= 1;
    }
}
