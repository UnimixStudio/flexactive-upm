using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Linq;

namespace Game.FlexActive
{
    /// <summary>
    /// Абстрактный композитный контроллер для объединения нескольких TweenActiveStateController компонентов.
    /// </summary>
    public abstract class CompositeTweenController : TweenActiveStateController
    {
        [SerializeField] private List<TweenActiveStateController> tweenControllers = new();

        public override Tween CreateTween()
        {
            IEnumerable<Tween> tweens = tweenControllers.Select(BuildTween);
            
            return ComposeTweens(tweens);
        }

        private static Tween BuildTween(TweenActiveStateController tweenController)
        {
            return tweenController.CreateTween();
        }

        // Абстрактный метод для формирования последовательности или параллельного запуска.
        protected abstract Tween ComposeTweens(IEnumerable<Tween> tweens);

        protected override void OnDisable()
        {
            base.OnDisable();

            foreach (TweenActiveStateController controller in tweenControllers)
            {
                controller.SetActive(false);
            }
        }
    }
}