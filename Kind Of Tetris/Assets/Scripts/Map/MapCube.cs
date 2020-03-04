using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapCube : MonoBehaviour
{
    public Directions around;
    public Neighbours neighb;
    [SerializeField] private LayerMask layerMask = 1 << 8;

    public bool pointed = false;
    public bool filled = false;
    public GameObject containing = null;
    
    private bool activated = true;
    private MeshRenderer mesh;
    private MapMaterials mat;

    // Start is called before the first frame update
    void Start()
    {
        mat = transform.root.GetComponent<MapMaterials>();
        mesh = GetComponent<MeshRenderer>();
        around.east = countDir("MapCube", 1, new Vector3(1, 0, 0));
        around.west = countDir("MapCube", 1, new Vector3(-1, 0, 0));
        around.north = countDir("MapCube", 1, new Vector3(0, 0, 1));
        around.south = countDir("MapCube", 1, new Vector3(0, 0, -1));
        around.up = countDir("MapCube", 1, new Vector3(0, 1, 0));
        around.down = countDir("MapCube", 1, new Vector3(0, -1, 0));

        neighb.east = neighbourDir("MapCube", 1, new Vector3(1, 0, 0), around.east, around.west, new Vector3(-around.west - 1, 0, 0));
        neighb.west = neighbourDir("MapCube", 1, new Vector3(-1, 0, 0), around.west, around.east, new Vector3(around.east + 1, 0, 0));
        neighb.north = neighbourDir("MapCube", 1, new Vector3(0, 0, 1), around.north, around.south, new Vector3(0, 0, -around.south - 1));
        neighb.south = neighbourDir("MapCube", 1, new Vector3(0, 0, -1), around.south, around.north, new Vector3(0, 0, around.north + 1));
        neighb.up = neighbourDir("MapCube", 1, new Vector3(0, 1, 0), around.up, around.down, new Vector3(0, -around.down - 1, 0));
        neighb.down = neighbourDir("MapCube", 1, new Vector3(0, -1, 0), around.down, around.up, new Vector3(0, around.up + 1, 0));
    }

    public bool isActivated()
    {
        return activated;
    }

    public void setActivated(bool b)
    {
        mesh.enabled = b;
        activated = b;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!filled && other.CompareTag("PieceCube"))
        {
            containing = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (!filled && other.transform.CompareTag("PieceCube"))
        {
            containing = null;
        }
    }

    public int countDir(string tag, float distance, Vector3 direction)
    {
        RaycastHit hit;
        if (Physics.Raycast(gameObject.transform.position, direction, out hit, distance, layerMask))
        {
            if (hit.transform.CompareTag(tag))
            {
                return hit.transform.GetComponent<MapCube>().countDir(tag, distance, direction) + 1;
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

    public void Point()
    {
        pointed = true;
        if (mat)
        {
            if (mat.pointed)
            {
                mesh.material = mat.pointed;
            }
        }
    }

    public void UnPoint()
    {
        pointed = false;
        if (mat)
        {
            if (mat.pointed)
            {
                mesh.material = mat.normal;
            }
        }
    }
}
