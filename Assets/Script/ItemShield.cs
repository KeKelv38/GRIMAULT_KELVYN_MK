using UnityEngine;

[CreateAssetMenu(fileName = "ItemShield", menuName = "Scriptable Objects/ItemShield")]
public class ItemShield : Item
{
    public override void Activation(PlayerItemManager player)
    {
        GameManager.instance.carControler.Shield();
    }
}
