using System.Collections.Generic;
using DG.Tweening;

namespace Game.FlexActive
{
    /// <summary>
    /// Последовательный запуск группы твинов.
    /// </summary>
    public class SequenceTweenController : CompositeTweenController
    {
        protected override Tween ComposeTweens(IEnumerable<Tween> tweens)
        {
            var sequence = DOTween.Sequence();
            foreach (var tween in tweens)
            {
                sequence.Append(tween);
            }
            return sequence;
        }
    }
}