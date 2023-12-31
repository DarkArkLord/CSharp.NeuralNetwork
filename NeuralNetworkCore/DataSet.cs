﻿namespace NeuralNetworkCore
{
    public struct DataSet
    {
        public double[] Input;
        public double[] Output;

        public static DataSet Make()
        {
            return new DataSet();
        }

        public DataSet SetInput(params double[] input)
        {
            Input = input.ToArray();
            return this;
        }

        public DataSet SetOutput(params double[] output)
        {
            Output = output.ToArray();
            return this;
        }
    }
}
