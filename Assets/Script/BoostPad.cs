using UnityEngine;

public class BoostPad : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CarControler playerCarControlerInContact = other.GetComponent<CarControler>();
        if (playerCarControlerInContact != null)
        {
            playerCarControlerInContact.Turbo();
        }
    }
}
