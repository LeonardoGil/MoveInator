using MoveInatorForms.Forms.Cards;
using MoveInatorForms.Services.Interfaces;

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

            var controls = updateService.Releases.OrderByDescending(x => x.CriadoEm)
                                                 .Take(takeReleases)
                                                 .ToList()
                                                 .Select(release => new ReleaseCardControl(release))
                                                 .ToArray();

            Invoke(() => flowLayoutPanel.Controls.AddRange(controls));
        }
    }
}
