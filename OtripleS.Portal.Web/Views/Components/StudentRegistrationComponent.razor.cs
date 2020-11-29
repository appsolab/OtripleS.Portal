﻿using System;
using OtripleS.Portal.Web.Views.Bases;

namespace OtripleS.Portal.Web.Views.Components
{
    public partial class StudentRegistrationComponent
    {
        public TextBoxBase TextBox { get; set; }

        public void ButtonClicked()
        {
            string textBoxValue = this.TextBox.Value;
            Console.WriteLine(textBoxValue);
        }
    }
}
