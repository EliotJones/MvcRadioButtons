﻿namespace EliotJones.RadioButtons.ViewModels
{
    using System;
    using System.Collections.Generic;

    public class StringGuidRadioButtons : KeyValueRadioButtons<string, Guid>
    {
        public StringGuidRadioButtons()
        {
            this.SelectedValue = Guid.Empty;
        }

        public StringGuidRadioButtons(IEnumerable<KeyValuePair<string, Guid>> keysAndValues) : base(keysAndValues)
        {
        }
    }
}