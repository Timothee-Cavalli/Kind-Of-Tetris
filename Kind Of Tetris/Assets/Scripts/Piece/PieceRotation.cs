using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceRotation : MonoBehaviour
{

    public bool rotating = false;

    private Vector3 c, d;
    private float elapsedR, durR = 0.5f;
    private List<PieceCube> childscripts = new List<PieceCube>();

    void Update()
    {
        if (rotating)
        {
            float lastR = elapsedR * 90 / durR;
            elapsedR += Time.deltaTime;
            float dd = ((elapsedR * 90 / durR) - lastR);
            if ((elapsedR * 90 / durR) > 90)
                dd -= (elapsedR * 90 / durR) - 90;
            foreach (PieceCube child in childscripts)
            {
                child.rotatePieceCube(c, d, dd);
            }
            if (elapsedR > durR)
            {
                rotating = false;
                foreach (PieceCube child in childscripts)
                {
                    child.checkSurrounding();
                }
            }
        }
    }

    public void rotatePiece(Vector3 angle, Vector3 origin)
    {
        c = angle;
        d = origin;
        rotating = true;
        elapsedR = 0;
    }

    public void setChild(List<PieceCube> ch)
    {
        childscripts = ch;
    }
}
