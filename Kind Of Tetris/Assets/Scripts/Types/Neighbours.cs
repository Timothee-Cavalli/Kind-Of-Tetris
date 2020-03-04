using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Cardinal
{
    north,
    south,
    east,
    west,
    up,
    down
}

public enum Move
{
    northM,
    southM,
    eastM,
    westM,
    upM,
    downM
}

public enum Rotate
{
    northR,
    southR,
    eastR,
    westR,
    upR,
    downR
}


[System.Serializable]
public class Neighbours 
{
    public GameObject north;
    public GameObject south;
    public GameObject east;
    public GameObject west;
    public GameObject up;
    public GameObject down;
}

[System.Serializable]
public class Directions
{
    public int north;
    public int south;
    public int east;
    public int west;
    public int up;
    public int down;
}