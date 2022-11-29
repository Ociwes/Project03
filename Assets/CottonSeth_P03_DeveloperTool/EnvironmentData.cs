using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnvironmentData_", menuName = "EnviromentSet")]
public class EnvironmentData : ScriptableObject
{
    [Header("Environment Props:")]
    [SerializeField] [Tooltip("Make sure lengths of each attribute match length of this data set!!!")] private GameObject[] _gameObjects;
    public GameObject[] GameObjects => _gameObjects;

    [Header("General Prop Attributes:")]
    [SerializeField] [Tooltip("Number of game objects placed within the area")] private int[] _amountOfObjects;
    public int[] AmountOfObjects => _amountOfObjects;

    [Header("Prop Translation Control:")]
    [SerializeField] [Tooltip("Determines max translation along the X axis. Goes in both positive and negative directions.")] private float[] _maxX;
    public float[] MaxX => _maxX;
    [SerializeField] [Tooltip("Determines max translation along the X axis. Goes in both positive and negative directions.")] private float[] _maxY;
    public float[] MaxY => _maxY;
    [SerializeField] [Tooltip("Determines max translation along the Z axis. Goes in both positive and negative directions.")] private float[] _maxZ;
    public float[] MaxZ => _maxZ;

    [Header("Prop Rotation Control:")]
    [SerializeField] [Tooltip("Maximum rotation relative to the X axis")] [Range(0,360)] private float[] _xRot;
    public float[] xRot => _xRot;
    [SerializeField] [Tooltip("Maximum rotation relative to the Y axis")] [Range(0, 360)] private float[] _yRot;
    public float[] yRot => _yRot;
    [SerializeField] [Tooltip("Maximum rotation relative to the Z axis")] [Range(0, 360)] private float[] _zRot;
    public float[] zRot => _zRot;

    [Header("Object Scale Control:")]
    [SerializeField] [Tooltip("If scale toggle is turned on, determines max scale along the X axis.")] private float[] _xScale;
    public float[] xScale => _xScale;
    [SerializeField] [Tooltip("If scale toggle is turned on, determines max scale along the Y axis.")] private float[] _yScale;
    public float[] yScale => _yScale;
    [SerializeField] [Tooltip("If scale toggle is turned on, determines max scale along the Z axis.")] private float[] _zScale;
    public float[] zScale => _zScale;
}
