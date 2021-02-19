using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checks8 : MonoBehaviour
{


    private void OnTriggerStay2D(Collider2D target)
    {
        CheckController.ifActive8 = true;
        CheckController.finish8 = 1;

    }


    private void OnTriggerExit2D(Collider2D target)
    {
        CheckController.ifActive8 = false;
        CheckController.finish8 = 0;
    }
}
