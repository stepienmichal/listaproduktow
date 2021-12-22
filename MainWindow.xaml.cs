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
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ListaProduktow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Produkt> ListaProduktow = null;
        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }
        private void PrzygotujWiazanie()
        {
            ListaProduktow = new ObservableCollection<Produkt>();
            ListaProduktow.Add(new Produkt("01-11", "ołówek", 8, "Katowice 1"));
            ListaProduktow.Add(new Produkt("PW-20", "pióro wieczne", 75, "Katowice 2"));
            ListaProduktow.Add(new Produkt("DZ-10", "długopis żelowy", 1121, "Katowice 1"));
            ListaProduktow.Add(new Produkt("DZ-12", "długopis kulkowy", 280, "Katowice 2"));
            lstProdukty.ItemsSource = ListaProduktow;

            //sortowanie po kolumnie oraz układa rosnący luyb malejący
            CollectionView widok = (CollectionView)CollectionViewSource.GetDefaultView(lstProdukty.ItemsSource);
            widok.SortDescriptions.Add(new SortDescription("Magazyn", ListSortDirection.Ascending));//Descending-malejąco
            widok.SortDescriptions.Add(new SortDescription("Nazwa", ListSortDirection.Ascending));

        }
    }
}
