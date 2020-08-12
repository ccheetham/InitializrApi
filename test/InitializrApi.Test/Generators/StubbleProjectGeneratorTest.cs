// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System.Threading.Tasks;
using FluentAssertions;
using Steeltoe.InitializrApi.Generators;
using Steeltoe.InitializrApi.Models;
using Xunit;

namespace Steeltoe.InitializrApi.Test.Generators
{
    public class StubbleProjectGeneratorTest
    {
        [Fact]
        public async Task GenerateProject()
        {
            // Arrange
            var spec = new ProjectSpecification();
            var generator = new StubbleProjectGenerator();

            // Act
            var stream = await generator.GenerateProject(spec);

            // Assert
            stream.Should().NotBeNull();
        }
    }
}