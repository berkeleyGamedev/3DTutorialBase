using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAttack : Ability
{

    public override void Use(Vector3 spawnPos)
    {
        cc_PS.Play();
    }

    #region Collision Methods
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyController>().DecreaseHealth(m_Info.Power);
        }
    }
    #endregion
}
