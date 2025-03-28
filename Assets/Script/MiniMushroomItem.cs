using UnityEngine;

[CreateAssetMenu(fileName = "ItemMini", menuName = "Scriptable Objects/ItemMini")]
public class MiniMushroomItem : Item
{
    public override void Activation(PlayerItemManager player)
    {
        player.carControler.MiniMod();
    }
}