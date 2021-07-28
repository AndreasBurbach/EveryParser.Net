namespace EveryParser.GrammarListener
{
    /// <summary>
    /// Type for ArraySlicing
    /// </summary>
    internal enum ArraySlicingType
    {
        Indexing,
        Slicing,
        StepSlicing,
        StartSlicing,
        StartStepSlicing,
        EndSlicing,
        EndStepSlicing,
        AllStepSlicing
    }

    internal static class ArraySlicingTypeExtension
    {
        /// <summary>
        /// Returns the count of parameters for each type of ArraySlicing
        /// </summary>
        /// <param name="type">ArraySlicingType</param>
        /// <returns>int</returns>
        internal static int GetParameterCount(this ArraySlicingType type)
        {
            switch (type)
            {
                case ArraySlicingType.Indexing:
                    return 2;

                case ArraySlicingType.Slicing:
                    return 3;

                case ArraySlicingType.StepSlicing:
                    return 4;

                case ArraySlicingType.StartSlicing:
                    return 2;

                case ArraySlicingType.StartStepSlicing:
                    return 3;

                case ArraySlicingType.EndSlicing:
                    return 2;

                case ArraySlicingType.EndStepSlicing:
                    return 3;

                case ArraySlicingType.AllStepSlicing:
                    return 2;
            }

            return -1;
        }
    }
}