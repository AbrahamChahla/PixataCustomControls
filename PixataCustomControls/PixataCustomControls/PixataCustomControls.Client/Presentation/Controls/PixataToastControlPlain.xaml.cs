﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace PixataCustomControls.Presentation.Controls {
  public partial class PixataToastControlPlain : PixataToastControlBase {
    public PixataToastControlPlain() {
      InitializeComponent();
    }

    public override string TitleText {
      set {
        TbTitle.Text = value;
      }
    }

    public override string MessageText {
      set {
        TbMessage.Text = value;
      }
    }

    private void Button_Click(object sender, RoutedEventArgs e) {
      CloseMe();
    }

  }
}
