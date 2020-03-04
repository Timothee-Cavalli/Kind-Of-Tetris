using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Piece : MonoBehaviour
{
    public Vector3 offset;
    public bool ok = false;
    public bool placed = false;

    public GameObject actual;

    private List<PieceCube> childscripts = new List<PieceCube>();
    
    private PieceRotation rotation = null;
    private PieceMovement movement = null;

    private Vector3 initPos;


    void Start()
    {
        initPos = transform.position;
        bool first = true;
        foreach (Transform child in transform)
        {
            childscripts.Add(child.GetComponent<PieceCube>());
            if (first)
            {
                actual = child.gameObject;
                first = false;
            }
        }
        rotation = GetComponent<PieceRotation>();
        if (rotation)
        {
            rotation.setChild(childscripts);
        }

        movement = GetComponent<PieceMovement>();
        if (movement)
        {
            movement.setRef(this);
        }
    }

    void Update()
    {
        if (actual != null)
        {
            offset = -actual.transform.localPosition;
        }
        checkOk();
    }

    private void checkOk()
    {
        if (IsMotionless())
        {
            ok = true;
            foreach (PieceCube child in childscripts)
            {
                if (!child.ok)
                {
                    ok = false;
                    break;
                }
            }
        }
    }

    public void PlacePiece(bool isPlaced)
    {
        placed = isPlaced;
        foreach (PieceCube child in childscripts)
        {
            child.PlacePieceCube(isPlaced);
        }
    }



    public void MoveRef(Move m)
    {
        if (actual != null && IsMotionless() && movement) {
            PieceCube p = actual.GetComponent<PieceCube>();
            switch (m)
            {
                case Move.eastM:
                    if (p.neighb.east != null)
                    {
                        movement.changeActual(p.neighb.east);
                    }
                    break;
                case Move.westM:
                    if (p.neighb.west != null)
                    {
                        movement.changeActual(p.neighb.west);
                    }
                    break;
                case Move.northM:
                    if (p.neighb.north != null)
                    {
                        movement.changeActual(p.neighb.north);
                    }
                    break;
                case Move.southM:
                    if (p.neighb.south != null)
                    {
                        movement.changeActual(p.neighb.south);
                    }
                    break;
                case Move.upM:
                    if (p.neighb.up != null)
                    {
                        movement.changeActual(p.neighb.up);
                    }
                    break;
                case Move.downM:
                    if (p.neighb.down != null)
                    {
                        movement.changeActual(p.neighb.down);
                    }
                    break;
                default:
                    break;
            }
        }
    }

    public void RotateRef(Rotate r)
    {
        if (actual != null && IsMotionless() && rotation != null)
        {
            switch (r)
            {
                case Rotate.upR:
                    rotation.rotatePiece(Vector3.up, new Vector3(0, 90, 0));
                    break;
                case Rotate.downR:
                    rotation.rotatePiece(Vector3.down, new Vector3(0, -90, 0));
                    break;
                case Rotate.eastR:
                    rotation.rotatePiece(Vector3.right, new Vector3(90, 0, 0));
                    break;
                case Rotate.westR:
                    rotation.rotatePiece(Vector3.left, new Vector3(-90, 0, 0));
                    break;
                case Rotate.northR:
                    rotation.rotatePiece(Vector3.forward, new Vector3(0, 0, 90));
                    break;
                case Rotate.southR:
                    rotation.rotatePiece(Vector3.back, new Vector3(0, 0, -90));
                    break;
                default:
                    break;
            }
        }
    }

    public bool IsMotionless()
    {
        if (!movement && !rotation)
            return false;
        else if (!movement)
            return !rotation.rotating;
        else if (!rotation)
            return !movement.moving;
        return !rotation.rotating && !movement.moving;
    }

    public void GoToInitPos()
    {
        transform.position = initPos;
    }
}



