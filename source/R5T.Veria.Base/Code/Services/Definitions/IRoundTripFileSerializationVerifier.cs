using System;


namespace R5T.Veria
{
    /// <summary>
    /// Allows verification that an object is the same after round-trip serialization then deserialization.
    /// </summary>
    public interface IRoundTripFileSerializationVerifier<T>
    {
        /// <summary>
        /// Performs serialization, deserialization, value-comparison, re-serialization, and file-comparison to verify that an object and file is the same after de/serialization.
        /// </summary>
        bool Verify(T value, string serializationFilePath1, string serializationFilePath2);
        /// <summary>
        /// Performs deserialization, serialization, file-comparison, re-deserialization, and value-comparison to verify that an object and file is the same after de/serialization.
        /// </summary>
        bool Verify(string sourceFilePath, string serializationFilePath);
    }
}
