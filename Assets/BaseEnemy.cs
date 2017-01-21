using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour {

    public abstract void Move();

    public abstract void Attack();

    public abstract void PlayerInRange();
}
