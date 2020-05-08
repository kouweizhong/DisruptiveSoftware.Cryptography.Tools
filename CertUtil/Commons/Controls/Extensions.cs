﻿using CertUtil.Commons.Controls.Validation.Impl;
using System.Windows.Forms;

namespace CertUtil.Commons.Controls
{
    public static class Extensions
    {
        public static bool IsValid(this Control control, IControlValidationRule rule)
        {
            return rule.IsValid(control);
        }

        public static void ToogleUseSystemPasswordChar(this TextBox control)
        {
            control.UseSystemPasswordChar = !control.UseSystemPasswordChar;
        }
    }
}