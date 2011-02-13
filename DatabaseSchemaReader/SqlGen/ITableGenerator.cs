﻿namespace DatabaseSchemaReader.SqlGen
{
    /// <summary>
    /// Generate a table DDL
    /// </summary>
    public interface ITableGenerator
    {
        /// <summary>
        /// Indicates whether schema will be written in DDL
        /// </summary>
        /// <value><c>true</c> if schema is written; otherwise, <c>false</c>.</value>
        bool IncludeSchema { get; set; }

        /// <summary>
        /// Writes the DDL.
        /// </summary>
        /// <returns></returns>
        string Write();
    }
}
