using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class used on Canvas UnityEvents
public class ItemSlotUI : MonoBehaviour
{
    [SerializeField] ItemSlot _slot;

    public void OnClearSlot()
    {
        _slot?.ClearSlot();
    }
}