using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AbilityInfo
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("How much power this ability has")]
    private int m_power;
    public int Power
    {
        get
        {
            return m_power;
        }
    }

    [SerializeField]
    [Tooltip("If attack shoots something, describes the range it can shoot")]
    private int m_range;
    public int Range
    {
        get
        {
            return m_range;
        }
    }
    #endregion
}
