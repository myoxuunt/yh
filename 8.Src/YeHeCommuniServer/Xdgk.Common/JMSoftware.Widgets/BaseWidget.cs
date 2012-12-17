//----------------------------------------------------------------------------
// ASCII Generator dotNET - Image to ASCII Art Conversion Program
// Copyright (C) 2008 Jonathan Mathews
//----------------------------------------------------------------------------
// This file is part of ASCII Generator dotNET.
//
// ASCII Generator dotNET is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//----------------------------------------------------------------------------
// http://www.jmsoftware.co.uk/                http://ascgen2.sourceforge.net/
// <info@jmsoftware.co.uk>                              <jmsoftware@gmail.com>
//----------------------------------------------------------------------------
// $Id: BaseWidget.cs,v 1.10 2008/01/31 15:32:03 wardog_uk Exp $
//----------------------------------------------------------------------------
using System;
using System.Windows.Forms;

namespace JMSoftware.Widgets
{
	/// <summary>
	/// Summary description for BaseWidget.
	/// </summary>
	public class BaseWidget : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Constructor
		/// </summary>
		public BaseWidget() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.SetTopLevel(false);
			this.Show();
			this.BringToFront();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // BaseWidget
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(134, 102);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "BaseWidget";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BaseWidget_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.BaseWidget_Closing);
            this.ResumeLayout(false);

		}
		#endregion

		private void BaseWidget_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
			e.Cancel = true;
			Visible = false;
		}

		private bool _Enabled;
		/// <summary>
		/// Replacement Enabled property to allow the form to still be moved when disabled
		/// </summary>
		public new bool Enabled {
			get {
				return _Enabled;
			}

			set {
				_Enabled = value;

				foreach (Control control in Controls) {
					control.Enabled = _Enabled;
				}
			}
		}

        private void BaseWidget_Load(object sender, EventArgs e)
        {

        }
	}
}
