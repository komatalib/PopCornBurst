using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checks9 : MonoBehaviour
{


    private void OnTriggerStay2D(Collider2D target)
    {
        CheckController.ifActive9 = true;
        CheckController.finish9 = 1;

    }


    private void OnTriggerExit2D(Collider2D target)
    {
        CheckController.ifActive9 = false;
        CheckController.finish9 = 0;
    }
}
