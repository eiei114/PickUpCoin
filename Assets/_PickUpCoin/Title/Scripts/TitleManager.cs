using System;
using Manager.Scene;
using UniRx;
using UnityEngine;

namespace _PickUpCoin.Title
{
    public class TitleManager : MonoBehaviour
    {
        [SerializeField] private TitleView titleView;
        [SerializeField] private OptionPopUp optionPopUp;
        [SerializeField] private RankingPopUp rankingPopUp;
        private void Start()
        {
            titleView.MatchingButtonObservable()
                .Take(1)
                .Subscribe(_ => SceneManager.LoadScene(SceneEnum.Title));
            //
            // titleView.RankingButtonObservable()
            //     .Subscribe(_ =>titleView.titleCanvas)
        }
    }
}
