using Microsoft.Win32;
using MySchoolScoreManagementUI.Applications.ViewModels;
using MySchoolScoreManagementUI.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Waf.Applications;
using System.Windows.Forms;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;

namespace MySchoolScoreManagementUI.Applications.Controllers
{
    [Export]
    public class MainController
    {
        private readonly RibbonViewModel _ribbonViewModel;
        [ImportingConstructor]
        public MainController(RibbonViewModel ribbonViewModel)
        {
            _ribbonViewModel = ribbonViewModel;
        }

        public void initialize()
        {
            _ribbonViewModel.CommandNew = new DelegateCommand(New);
            _ribbonViewModel.CommandRead = new DelegateCommand(Read);
            _ribbonViewModel.CommandExport = new DelegateCommand(Export);
        }

        public void New()
        {
            ModelManger.Instance.ClearData();
        }

        public void Read()
        {
            ModelManger.Instance.ReadData();
        }

        public void Export()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                DefaultExt = "csv",
                Filter = "(*.csv)|*.csv",
                Title = "Export data"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ModelManger.Instance.ExportData(saveFileDialog.FileName);
            }
        }
    }
}
