using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceCube : MonoBehaviour
{
    public bool placed;
    public Directions around;
    public Neighbours neighb;
    public bool ok = false;
    public GameObject touching = null;
    [SerializeField] private LayerMask layerMask = 1 << 9;


    void Start()
    {
        checkSurrounding();
    }

    // Update is called once per frame
    void Update()
    {
        if (touching == null)
        {
            ok = false;
        }
    }

    private void FixedUpdate()
    {
        Collider[] hitColliders = Physics.OverlapBox(transform.position, transform.localScale / 2, Quaternion.identity);
        int i = 0;
        while (i < hitColliders.Length)
        {
            touching = null;
            ok = false;
            if (hitColliders[i].CompareTag("MapCube"))
            {
                if (!hitColliders[i].GetComponent<MapCube>().filled || placed)
                {
                    ok = true;
                }
                touching = hitColliders[i].gameObject;
            }
            i++;
        }
    }

    public void checkSurrounding()
    {
        around.east = countDir("PieceCube", 1, new Vector3(1, 0, 0));
        around.west = countDir("PieceCube", 1, new Vector3(-1, 0, 0));
        around.north = countDir("PieceCube", 1, new Vector3(0, 0, 1));
        around.south = countDir("PieceCube", 1, new Vector3(0, 0, -1));
        around.up = countDir("PieceCube", 1, new Vector3(0, 1, 0));
        around.down = countDir("PieceCube", 1, new Vector3(0, -1, 0));

        neighb.east = neighbourDir("PieceCube", 1, new Vector3(1, 0, 0), around.east, around.west, new Vector3(-around.west - 1, 0, 0));
        neighb.west = neighbourDir("PieceCube", 1, new Vector3(-1, 0, 0), around.west, around.east, new Vector3(around.east + 1, 0, 0));
        neighb.north = neighbourDir("PieceCube", 1, new Vector3(0, 0, 1), around.north, around.south, new Vector3(0, 0, -around.south - 1));
        neighb.south = neighbourDir("PieceCube", 1, new Vector3(0, 0, -1), around.south, around.north, new Vector3(0, 0, around.north + 1));
        neighb.up = neighbourDir("PieceCube", 1, new Vector3(0, 1, 0), around.up, around.down, new Vector3(0, -around.down - 1, 0));
        neighb.down = neighbourDir("PieceCube", 1, new Vector3(0, -1, 0), around.down, around.up, new Vector3(0, around.up + 1, 0));
    }

    public void PlacePieceCube(bool isPlaced)
    {
        placed = isPlaced;
        if (touching != null)
        {
            touching.GetComponent<MapCube>().filled = isPlaced;
        }
    }

    public int countDir(string tag, float distance, Vector3 direction)
    {
        RaycastHit hit;
        if (Physics.Raycast(gameObject.transform.position, direction, out hit, distance, layerMask))
        {
            if (hit.transform.CompareTag(tag))
            {
                return hit.transform.GetComponent<PieceCube>().countDir(tag, distance, direction) + 1;
            }
        }
        return 0;
    }

    public GameObject neighbourDir(string tag, float distance, Vector3 direction, int dir, int opDir, Vector3 opVec)
    {
        if (dir > 0)
        {
            RaycastHit hit;
            if (Physics.Raycast(gameObject.transform.position, direction, out hit, distance, layerMask))
            {
                if (hit.transform.CompareTag(tag))
                {
                    return hit.transform.gameObject;
                }
            }
        }
        else if (opDir > 0)
        {
            RaycastHit hit;
            if (Physics.Raycast(gameObject.transform.position + opVec, direction, out hit, distance, layerMask))
            {
                if (hit.transform.CompareTag(tag))
                {
                    return hit.transform.gameObject;
                }
            }
        }
        return null;
    }

    public void rotatePieceCube(Vector3 angle, Vector3 origin, float dir)
    {
        transform.RotateAround(angle, origin, dir);
    }
}

