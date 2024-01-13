using MoveInatorForms.Forms.Cards;
using MoveInatorForms.Services.Interfaces;
using System.Reflection;
using System.Windows.Forms;

namespace MoveInatorForms.Forms.Views
{
    public partial class NovidadesViewControl : UserControl
    {
        private readonly IUpdateService updateService;

        public NovidadesViewControl(IUpdateService updateService)
        {
            this.updateService = updateService;
            InitializeComponent();
            Task.Run(LoadReleases);
        }

        private void LoadReleases()
        {
            var takeReleases = updateService.Releases.Count > 10 ? 10 : updateService.Releases.Count;

            updateService.Releases.OrderByDescending(x => x.CriadoEm)
                                  .Take(takeReleases)
                                  .ToList()
                                  .ForEach(r => Invoke(() => flowLayoutPanel.Controls.Add(new ReleaseCardControl(r))));
        }
    }
}
