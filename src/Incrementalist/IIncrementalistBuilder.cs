﻿// -----------------------------------------------------------------------
// <copyright file="IIncrementalistBuilder.cs" company="Petabridge, LLC">
//      Copyright (C) 2015 - 2019 Petabridge, LLC <https://petabridge.com>
// </copyright>
// -----------------------------------------------------------------------

namespace Incrementalist
{
    /// <summary>
    /// Used to build all of the <see cref="IBuildCommand"/>s into a
    /// linear execution graph.
    /// </summary>
    //public interface IIncrementalistBuilder<TOutput>
    //{
    //    BuildSettings Settings { get; }

    //    ILogger Logger { get; }

    //    IEnumerable<string> ExecutionPlan { get; }

    //    IIncrementalistBuilder<TOutput> WithSettings(BuildSettings settings);

    //    IIncrementalistBuilder<TOutput> WithLogger(ILogger logger);

    //    IIncrementalistBuilder<TOutput> Next(IBuildCommand cmd);

    //    /// <summary>
    //    /// Validates the setup prior to execution.
    //    /// </summary>
    //    void Validate();

    //    /// <summary>
    //    /// Runs the commands
    //    /// </summary>
    //    /// <returns>The output from the final task in the build chain.</returns>
    //    Task<TOutput> Run();
    //}
}