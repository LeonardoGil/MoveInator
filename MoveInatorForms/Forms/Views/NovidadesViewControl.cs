﻿using MoveInatorForms.Forms.Cards;
using MoveInatorForms.Services.Interfaces;

namespace MoveInatorForms.Forms.Views
{
    public partial class NovidadesViewControl : BaseViewControl
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
            var controls = updateService.Releases.OrderByDescending(x => x.CriadoEm).ToList()
                                                 .Select(release => new ReleaseCardControl(release)).ToArray();

            Invoke(() => flowLayoutPanel.Controls.AddRange(controls));
        }
    }
}
