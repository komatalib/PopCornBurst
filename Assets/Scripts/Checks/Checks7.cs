using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checks7 : MonoBehaviour
{


    private void OnTriggerStay2D(Collider2D target)
    {
        CheckController.ifActive7 = true;
        CheckController.finish7 = 1;

    }


    private void OnTriggerExit2D(Collider2D target)
    {
        CheckController.ifActive7 = false;
        CheckController.finish7 = 0;
    }
}
