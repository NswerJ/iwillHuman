using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Shootmode
{
    Left,
    Right,
    Up,
    Down
};

public class Tower : MonoBehaviour
{
    public Shootmode _shootMode;
}
