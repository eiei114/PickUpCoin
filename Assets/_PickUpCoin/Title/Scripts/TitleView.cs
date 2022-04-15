using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace _PickUpCoin.Title
{
    public class TitleView : MonoBehaviour
    {
        [SerializeField] private Button matchingButton;
        [SerializeField] private Button rankingButton;
        [SerializeField] private Button optionButton;
        [SerializeField] private Button exitButton;

        [SerializeField] private List<GameObject> titleCanvas;
        
        public IObservable<Unit> MatchingButtonObservable() => matchingButton.OnClickAsObservable();
        public IObservable<Unit> RankingButtonObservable() => rankingButton.OnClickAsObservable();
        public IObservable<Unit> OptionButtonObservable() => optionButton.OnClickAsObservable();
        public IObservable<Unit> ExitButtonObservable() => exitButton.OnClickAsObservable();
    }
}
