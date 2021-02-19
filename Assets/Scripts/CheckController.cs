using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckController : MonoBehaviour
{
    public static int finishCount, finish1, finish2, finish3, finish4, finish5, finish6, finish7, finish8, finish9;
    public GameObject check1, check2, check3, check4, check5, check6, check7, check8, check9;
    public static bool ifActive1, ifActive2, ifActive3, ifActive4, ifActive5, ifActive6, ifActive7, ifActive8, ifActive9;

    private void Start()
    {
        check1.gameObject.SetActive(false);
    }

    private void Update()
    {
        Finish();

        if (ifActive1)
        {
            check1.gameObject.SetActive(true);
        }
        if(!ifActive1)
        {
            check1.gameObject.SetActive(false);
        }
        if (ifActive2)
        {
            check2.gameObject.SetActive(true);
        }
        if (!ifActive2)
        {
            check2.gameObject.SetActive(false);
        }
        if (ifActive3)
        {
            check3.gameObject.SetActive(true);
        }
        if (!ifActive3)
        {
            check3.gameObject.SetActive(false);
        }
        if (ifActive4)
        {
            check4.gameObject.SetActive(true);
        }
        if (!ifActive4)
        {
            check4.gameObject.SetActive(false);
        }
        if (ifActive5)
        {
            check5.gameObject.SetActive(true);
        }
        if (!ifActive5)
        {
            check5.gameObject.SetActive(false);
        }
        if (ifActive6)
        {
            check6.gameObject.SetActive(true);
        }
        if (!ifActive6)
        {
            check6.gameObject.SetActive(false);
        }
        if (ifActive7)
        {
            check7.gameObject.SetActive(true);
        }
        if (!ifActive7)
        {
            check7.gameObject.SetActive(false);
        }
        if (ifActive8)
        {
            check8.gameObject.SetActive(true);
        }
        if (!ifActive8)
        {
            check8.gameObject.SetActive(false);
        }
        if (ifActive9)
        {
            check9.gameObject.SetActive(true);
        }
        if (!ifActive9)
        {
            check9.gameObject.SetActive(false);
        }

    }

    
    public void Finish()
    {
        finishCount = finish1 + finish2 + finish3 + finish4 + finish5 + finish6 + finish7 + finish8 + finish9;

    }

}
