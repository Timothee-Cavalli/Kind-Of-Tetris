using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMovement : MonoBehaviour
{

    public bool moving = false;
    private Vector3 b, a;
    private float elapsedM, durM = 0.5f;

    private Piece pp;

    void Update()
    {
        if (moving)
        {
            elapsedM += Time.deltaTime;
            pp.offset = -Vector3.Lerp(a, b, elapsedM / durM);
            if (elapsedM > durM)
                moving = false;

        }
    }

    public void changeActual(GameObject newg)
    {
        a = pp.actual.transform.localPosition;
        pp.actual = newg;
        b = pp.actual.transform.localPosition;
        elapsedM = 0;
        moving = true;
    }

    public void setRef(Piece p)
    {
        pp = p;
    }
}
