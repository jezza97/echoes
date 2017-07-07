﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : ScriptableObject {

    public GameObject[,] board;

    int sizeX;
    int sizeY;

    int[] bottomLeft;

    Region<Room> region;

    public Room()
    {

    }

    public void init(GameObject[,] board, int[] bottomLeft, int sizeX, int sizeY)
    {
        this.board = board;
        this.bottomLeft = bottomLeft;
        this.sizeX = sizeX;
        this.sizeY = sizeY;
    }

    public Region<Room> getRegion()
    {
        return this.region;
    }

    public void setRegion(Region<Room> region)
    {
        this.region = region;
    }

}