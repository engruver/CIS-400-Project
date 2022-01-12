﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CoinControl.xaml
    /// </summary>
    public partial class CoinControl : UserControl
    {
        /// <summary>
        /// The property indicating the denomination
        /// </summary>
        public static readonly DependencyProperty DenominationProperty =
            DependencyProperty.Register("Denomination", typeof(string), typeof(CoinControl), new PropertyMetadata("Pennies"));

        /// <summary>
        /// The Denomination this control displays and modifies
        /// </summary>
        public string Denomination
        {
            get { return (string)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }

        /// <summary>
        /// The quantity of coins
        /// </summary>
        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register("Quantity", typeof(int), typeof(CoinControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// Gets or sets the quantity of coin
        /// </summary>
        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set => SetValue(QuantityProperty, value);
        }

        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }

        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity--;
        }

        public CoinControl()
        {
            InitializeComponent();
        }
    }
}
