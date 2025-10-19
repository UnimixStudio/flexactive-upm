using System.Collections.Generic;
using DG.Tweening;

namespace Game.FlexActive
{
    /// <summary>
    /// Одновременный запуск группы твинов.
    /// </summary>
    public class ParallelTweenController : CompositeTweenController
    {
        protected override Tween ComposeTweens(IEnumerable<Tween> tweens)
        {
            var sequence = DOTween.Sequence();
            foreach (var tween in tweens)
            {
                sequence.Join(tween);
            }
            return sequence;
        }
    }
}