﻿using System;
using System.Collections.Generic;
using Abstractions;

namespace Engine
{
    internal static class TestStepExecutorGenerator
    {
        public static ITestStepExecutor Generate(ITestStep testStep, IComputer computer, IReadOnlyList<IImageService> imageSerivces, ILogger logger)
        {
            if (string.Equals(testStep.Target, "image", StringComparison.OrdinalIgnoreCase))
            {
                return new TestStepForImage(imageSerivces, computer, testStep, logger);
            }
            else if (string.Equals(testStep.Target, "text", StringComparison.OrdinalIgnoreCase))
            {
                return new TestStepForText(imageSerivces, computer, testStep, logger);
            }
            else if (string.IsNullOrEmpty(testStep.Target))
            {
                return new TestStepForActionOnly(computer, testStep, logger);
            }

            return null;
        }
    }
}