﻿namespace MachineLearningLIB.LearningAlgorithms
{
    public class BackpropagationDelta
    {
        public double BiasUpdate;
        public double[] Momentums;
        public double[] WeightUpdates;
        public double PartialDerivative;
        public double[] LastWeightUpdates;

        public BackpropagationDelta(int numberOfWeights)
        {
            LastWeightUpdates = new double[numberOfWeights];
            WeightUpdates = new double[numberOfWeights];
            Momentums = new double[numberOfWeights];
            Initialize();
        }

        public void Initialize()
        {
            BiasUpdate = 0;
            PartialDerivative = 0;
            for (int i = 0; i < WeightUpdates.Length; i++)
            {
                Momentums[i] = 0;
                WeightUpdates[i] = 0;
                LastWeightUpdates[i] = 0;
            }
        }
    }

}
