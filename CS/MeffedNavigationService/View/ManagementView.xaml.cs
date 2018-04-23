﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MeffedNavigationService.Infrastructure.Contract;
using MeffedNavigationService.Infrastructure.Enums;

namespace MeffedNavigationService.ModuleA.View {
    /// <summary>
    /// Interaction logic for ViewA1.xaml
    /// </summary>
    [ExportView(ModuleType = ModuleTypes.ViewManagement)]
    public partial class ManagementView : UserControl, IModule {
        public ManagementView() {
            InitializeComponent();
        }
    }
}
