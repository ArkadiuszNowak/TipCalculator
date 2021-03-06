﻿using System;
using UIKit;
using CoreGraphics;

namespace TipCalculator
{
    public class MyViewController : UIViewController
    {
        public MyViewController()
        {
        }
        
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.View.BackgroundColor = UIColor.Yellow;

            UITextField totalAmount = new UITextField(new CGRect(20, 28, View.Bounds.Width-40, 35)) {
                KeyboardType = UIKeyboardType.DecimalPad,
                BorderStyle = UITextBorderStyle.RoundedRect,
                Placeholder = "Enter Total Amount"
            };

            UIButton calcButton = new UIButton(UIButtonType.Custom) {
                Frame = new CGRect(20, 71, View.Bounds.Width - 40, 45),
                BackgroundColor = UIColor.FromRGB(0, 0.5f, 0),
            };
            calcButton.SetTitle("Calculate", UIControlState.Normal);

            UILabel resultLabel = new UILabel(new CGRect(0, 124, View.Bounds.Width, 40)) {
                TextColor = UIColor.Blue,
                TextAlignment = UITextAlignment.Center,
                Font = UIFont.SystemFontOfSize(24),
                Text = "Tip is $0.00"
            };

            View.AddSubviews(totalAmount, calcButton, resultLabel);
        }
    }
}

