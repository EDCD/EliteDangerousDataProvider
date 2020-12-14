﻿using Cottle.Functions;
using Cottle.Values;
using EddiDataDefinitions;
using EddiSpeechResponder.Service;
using JetBrains.Annotations;

namespace EddiSpeechResponder.CustomFunctions
{
    [UsedImplicitly]
    public class GovernmentDetails : ICustomFunction
    {
        public string name => "GovernmentDetails";
        public FunctionCategory Category => FunctionCategory.Details;
        public string description => Properties.CustomFunctions_Untranslated.GovernmentDetails;
        public NativeFunction function => new NativeFunction((values) =>
        {
            Government result = Government.FromName(values[0].AsString);
            if (result == null)
            {
                result = Government.FromName(values[0].AsString);
            }
            return new ReflectionValue(result ?? new object());
        }, 1);
    }
}
