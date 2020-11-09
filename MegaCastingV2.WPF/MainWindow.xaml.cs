﻿using MegaCastingV2.DBLib;
using MegaCastingV2.WPF.View;
using MegaCastingV2.WPF.ViewModel;
using System;
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

namespace MegaCastingV2.WPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Attributes

        /// <summary>
        /// Contexte de l'application
        /// </summary>
        private Entities _Entities;


        /// <summary>
        /// Vue Modèle de la fenêtre principale
        /// </summary>
        private ViewModelMainWindow _ViewModel;

        private EMPLOYEE _CurrentEmployee;


        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou défini le contexte de l'application
        /// </summary>
        public Entities Entities
        {
            get { return _Entities; }
            set { _Entities = value; }
        }

        /// <summary>
        /// Obtient ou défini le vue modèle de la fenêtre principal        
        /// </summary>
        public ViewModelMainWindow ViewModel
        {
            get { return _ViewModel; }
            set { _ViewModel = value; }
        }

        public EMPLOYEE CurrentEmployee
        {
            get { return _CurrentEmployee; }
            set { _CurrentEmployee = value; }
        }


        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            this.Entities = new Entities();

            this.Entities.USERS.FirstOrDefault();

        }

        #endregion


        /// <summary>
        /// Défini le dockPanel comme affichant le type de user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageUserType_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();

            ViewModelUserType viewModel = new ViewModelUserType(Entities);

            ViewUser view = new ViewUser();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
            

        }

        /// <summary>
        /// Defini le button de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ButtonConnect_Click(object sender, RoutedEventArgs e)
        {
            
            this.CurrentEmployee = this.Entities.EMPLOYEEs
                .FirstOrDefault(employee => employee.EMPLOYEE_USERNAME == _TextBoxId.Text && employee.EMPLOYEE_PASSWORD == _TextBoxPassWord.Password);

            if (CurrentEmployee == null)
            {
                _TextBoxId.Text = "";
                _TextBoxPassWord.Password = "";
                _LabelErrorMessage.Visibility = Visibility.Visible;

            }
            else
            {
                _GridAuthentication.Visibility = Visibility.Collapsed;
            }
        }


        /// <summary>
        /// Définie le dockpanel pour afficher les castings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageCastingsType_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();

            ViewModelCastingsType viewModel = new ViewModelCastingsType(Entities);

            ViewCastings view = new ViewCastings();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        /// <summary>
        /// Défini le dockPanel comme affichant le type de Categorie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageCategory_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();
            ViewModelCategory viewModel = new ViewModelCategory(Entities);

            ViewCategory view = new ViewCategory();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        /// <summary>
        /// Défini le dockPanel comme affichant le type de Pack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManagePack_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();
            ViewModelPack viewModel = new ViewModelPack(Entities);

            ViewPack view = new ViewPack();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        /// <summary>
        /// Défini le dockPanel comme affichant le type de organisation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageOrganisation_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();

            ViewModelOrga viewModel = new ViewModelOrga(Entities);

            ViewOrganisation view = new ViewOrganisation();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }


        //#region EventWindows 
        ///// <summary>
        ///// Action permettant de reduire la fenètre
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void ButtonMinimanizScrean_Click(object sender, RoutedEventArgs e)
        //{
        //    WindowState = WindowState.Minimized;
        //}

        ///// <summary>
        ///// Action permettant d'agrandir ou de réduir la fenètre
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void ButtonFullScrean_Click(object sender, RoutedEventArgs e)
        //{
        //    WindowState = (WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized;
        //}

        ///// <summary>
        ///// Action permettant de fermer la fenètre
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void ButtonExit_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}


        //#endregion

    }
}
