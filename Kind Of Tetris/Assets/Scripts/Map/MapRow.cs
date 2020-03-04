using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRow : MonoBehaviour
{
    private List<MapCube> cubes = new List<MapCube>();
    private bool activated = true;
    void Start()
    {
       foreach (Transform child in transform)
        {
            cubes.Add(child.GetComponent<MapCube>());
        }
    }

    // Update is called once per frame
    public bool CheckVictory()
    {
        foreach (MapCube cc in cubes)
        {
            if (!cc.filled)
                return false;
        }
        return true;
    }

    public void setActivated(bool b)
    {
        foreach (MapCube cc in cubes)
        {
            cc.setActivated(b);
        }
    }

    public bool isActivated()
    {
        return activated;
    }
}
