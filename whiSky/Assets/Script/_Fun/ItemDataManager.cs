using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataManager : MonoBehaviour
{
    private enum itemType
    {
        Equip,
        Use,
        Totem,
        Module,
        Resource
    }

    private enum itemEquipType
    {
        Head,
        Upper,
        Lower,
        Glove,
        Boots,
        Bag
    }

    private string[] itemName;
    private string[] itemIcon;
    private string[] itemDescription;
    private string[] itemStatType;
    private string[,] itemStatValue;
}
