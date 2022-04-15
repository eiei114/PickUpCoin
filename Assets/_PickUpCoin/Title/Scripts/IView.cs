using UnityEngine;

namespace _PickUpCoin.Title
{
    public interface IView
    {
        void PopUpView(GameObject viewObject);

        void CloseView(GameObject viewObject);
    }
}