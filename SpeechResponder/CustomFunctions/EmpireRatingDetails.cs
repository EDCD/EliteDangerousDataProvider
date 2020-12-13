﻿using Cottle.Functions;
using Cottle.Values;
using EddiDataDefinitions;
using EddiSpeechResponder.Service;
using JetBrains.Annotations;

namespace EddiSpeechResponder.CustomFunctions
{
    [UsedImplicitly]
    public class EmpireRatingDetails : ICustomFunction
    {
        public string name => "EmpireRatingDetails";
        public FunctionCategory Category => FunctionCategory.Details;
        public string description => @"
This function will provide full information for an empire rating given its name.

EmpireRatingDetails() takes a single argument of the empire rating for which you want more information.

Common usage of this is to provide further information about your rating, for example:

    You have been promoted {EmpireRatingDetails(""Lord"").rank} times.";
        public NativeFunction function => new NativeFunction((values) =>
        {
            EmpireRating result = EmpireRating.FromName(values[0].AsString);
            if (result == null)
            {
                result = EmpireRating.FromEDName(values[0].AsString);
            }
            return new ReflectionValue(result ?? new object());
        }, 1);
    }
}