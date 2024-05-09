﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HajósTeszt
{
    public class ValaszGomb : TextBox
    {
        public ValaszGomb()
        {
            BackColor = Color.LightGray;
            Multiline = true;
            ReadOnly = true;

            MouseEnter += VálaszGomb_MouseEnter;
            MouseLeave += VálaszGomb_MouseLeave;

            BorderStyle = BorderStyle.None;
            Cursor = Cursors.Hand;
        }

        private void VálaszGomb_MouseLeave(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }

        private void VálaszGomb_MouseEnter(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
