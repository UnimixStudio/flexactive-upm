using DG.Tweening;
using UnityEngine;

namespace Game.FlexActive
{
    /// <summary>
    /// Абстрактный компонент для управления жизненным циклом DOTween-анимаций.
    /// Tweens начинают проигрываться при активации и полностью очищаются при деактивации.
    /// </summary>
    public abstract class TweenActiveStateController : ActiveStateController
    {
        protected Tween Tween;

        public override void SetActive(bool active)
        {
            if (active)
                PlayTween();
            else
                StopTween();
        }

        public abstract Tween CreateTween();

        protected virtual void PlayTween()
        {
            StopTween(); // На всякий случай остановим предыдущий твин
            Tween = CreateTween();
            Tween.Play();
        }

        protected virtual void StopTween()
        {
            Tween?.Kill();
            Tween = null;
        }

        protected virtual void OnDisable()
        {
            StopTween(); // Автоматическая очистка анимации при отключении компонента
        }
    }
}