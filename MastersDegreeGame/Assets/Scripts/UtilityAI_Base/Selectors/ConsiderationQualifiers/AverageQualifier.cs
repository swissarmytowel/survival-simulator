using System;
using System.Collections.Generic;
using UtilityAI_Base.Considerations;
using UtilityAI_Base.Contexts;
using UtilityAI_Base.Contexts.Interfaces;

namespace UtilityAI_Base.Selectors.ConsiderationQualifiers
{
    [Serializable]
    public class AverageQualifier : ConsiderationsQualifier
    {
        public new string description = "avg qualifier";
        
        public override float Qualify(AiContext context, List<Consideration> considerations) {
            var averageScore = 0f;
            foreach (var consideration in considerations) {
                if (consideration.isEnabled) {
                    var score = consideration.Evaluate(context);
                    if (consideration.canApplyVeto && Math.Abs(score) < 1e-3) {
                        return 0f;
                    }

                    averageScore += score;
                }
            }
            return averageScore / considerations.Count;
        }
    }
}