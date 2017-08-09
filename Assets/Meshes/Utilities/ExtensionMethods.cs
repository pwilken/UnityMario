﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static Vector3 Vector3(float x, float y, float size)
        {
            return new Vector3(x * size, y * size);
        }

        public static Vector3 Vector3(float x, float y, float z, float size)
        {
            return new Vector3(x * size, y * size, z * size);
        }

        public static Vector3 Vector3(float x, float y, float z, float width, float height, float depth)
        {
            return new Vector3(x * width, y * height, z * depth);
        }

        public static List<Vector2> FindEmptyLocationsAboveGround(Level[,] map)
        {
            List<Vector2> emptyLocationsAboveGround = new List<Vector2>();

            for (int r = map.GetLength(0); r > 0; r--)
            {
                for (int c = 0; c < map.GetLength(1); c++)
                {
                    if (r > 0 && map[r, c] == Level.GROUND && map[r - 1, c] == Level.EMPTY)
                    {
                        emptyLocationsAboveGround.Add(new Vector2(c, r - 1));
                    }
                }
            }

            return emptyLocationsAboveGround;
        }
    }
}
