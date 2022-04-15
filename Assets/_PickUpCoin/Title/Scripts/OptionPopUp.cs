using UnityEngine;

namespace _PickUpCoin.Title
{
    public class OptionPopUp : MonoBehaviour, IView
    {
        public void PopUpView(GameObject viewObject)
        {
            viewObject.SetActive(true);
        }

        public void CloseView(GameObject viewObject)
        {
            viewObject.SetActive(false);
        }
    }
}