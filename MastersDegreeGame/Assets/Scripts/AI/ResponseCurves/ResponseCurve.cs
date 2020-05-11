using AI.ResponseCurves.Interfaces;

namespace AI.ResponseCurves
{
    /// <summary>
    /// Abstract class for utility curve representation
    /// All custom utility curves must implement this class 
    /// </summary>
    /// <typeparam name="T">curve axis data type</typeparam>
    public abstract class ResponseCurve<T> : IResponseCurve<T>
    {
        public abstract float EvaluateAt(T parameter);
        public abstract float CurveFunction(T parameter);
    }
}