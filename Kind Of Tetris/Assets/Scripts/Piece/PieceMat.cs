using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMat : MonoBehaviour
{
    public Material okMat;
    public Material nopeMat;
    private List<MeshRenderer> childsMesh = new List<MeshRenderer>();
    private Piece dad;
    private bool bef = false;

    void Start()
    {
        dad = GetComponent<Piece>();
        foreach (Transform child in transform)
        {
            childsMesh.Add(child.GetComponent<MeshRenderer>());
            if (okMat != null)
            {
                child.GetComponent<MeshRenderer>().material = okMat;
            }
        }
    }

    void Update()
    {
        if (dad.IsMotionless())
        {
            if (dad.ok) {
                foreach (Transform child in transform)
                {
                    if (okMat != null)
                    {
                        child.GetComponent<MeshRenderer>().material = okMat;
                    }
                }
            }
            else if (!dad.ok)
            {
                foreach (Transform child in transform)
                {
                    if (nopeMat != null)
                    {
                        child.GetComponent<MeshRenderer>().material = nopeMat;
                    }
                }
            }
        }
        bef = dad.ok;
    }
}
