using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapManager : MonoBehaviour
{
    private List<MapRow> rows = new List<MapRow>();
    public bool filled;
    void Start()
    {
        foreach (Transform child in transform)
        {
            rows.Add(child.GetComponent<MapRow>());
        }
    }

    // Update is called once per frame
    public bool CheckVictory()
    {
        foreach (MapRow rr in rows)
        {
            if (!rr.CheckVictory())
                return false;
        }
        return true;
    }

    public void setRowActivated(int i, bool b)
    {
        if (i < rows.Count)
            rows[i].setActivated(b);
    }
}
